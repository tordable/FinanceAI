using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Windows.Forms;

// TODO: Remove dependency AI, only for classificationData
using FinanceAI.AI;
using FinanceAI.Data.Samples;

namespace FinanceAI.UI
{
    public partial class LoadTrainTestDataForm : Form
    {
        private enum TrainTestSplitMode
        {
            InvalidSplit = -1,
            NoSplit,
            RandomSplit,
            DateSplit,
            TickerSplit
        }

        private DataContext dc;

        // Load parameters
        private TrainTestSplitMode splitMode;

        private bool useQData;

        private bool useYData;

        private int randomSplitPercentage = 80;

        private DateTime dateSplitCutoff = new DateTime( 2007, 12, 31 );

        private List<string> selectedTickers = new List<string>( );

        // Classification data
        private ClassificationData trainData = new ClassificationData( );

        public ClassificationData TrainData
        {
            get
            {
                return trainData;
            }
        }

        private ClassificationData testData = new ClassificationData( );

        public ClassificationData TestData
        {
            get
            {
                return testData;
            }
        }

        // Constructor        
        public LoadTrainTestDataForm( DataContext dc )
        {
            this.dc = dc;
            InitializeComponent( );

            // Set defaults
            useQData = true;
            useQDataCheckBox.Checked = true;

            useYData = false;
            useYDataCheckBox.Checked = false;

            splitMode = TrainTestSplitMode.NoSplit; 
            noTestSplitRadioButton.Select( );
            
            randomPercentageTextBox.Text = randomSplitPercentage.ToString( );
            dateSplitPicker.Value = dateSplitCutoff;

            // Show available data
            UpdateAvailableData( );
        }

        // Update the ticker list to filter by ticker
        public void UpdateAvailableData( )
        {
            // Load the list of tickers to show
            IEnumerable<string> tickers = new List<string>( );
            IEnumerable<string> qTickers =
                from sample in dc.GetTable<QLSample>( )
                select sample.Ticker;
            IEnumerable<string> yTickers =
                from sample in dc.GetTable<YLSample>( )
                select sample.Ticker;

            // Add the corresponding tickers
            if (useQData)
            {
                tickers = tickers.Union( qTickers );
            }
            if (useYData)
            {
                tickers = tickers.Union( yTickers );
            }

            // Add the tickers to the checked box
            companyTrainingCheckedBox.Items.Clear( );
            foreach (string ticker in tickers)
            {
                companyTrainingCheckedBox.Items.Add( ticker );
            }
        }

        // Processing of the checked boxes

        private void useQDataCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            if (useQDataCheckBox.Checked == true)
            {
                useQData = true;
            }
            else
            {
                useQData = false;
            }

            UpdateAvailableData( );
        }

        private void useYDataCheckBox_CheckedChanged( object sender, EventArgs e )
        {
            if (useYDataCheckBox.Checked == true)
            {
                useYData = true;
            }
            else
            {
                useYData = false;
            }

            UpdateAvailableData( );
        }

        // Processing of the radio buttons

        private void noTestSplitRadioButton_CheckedChanged( object sender, EventArgs e )
        {
            // Disable the input controls of the other options
            randomPercentageTextBox.Enabled = false;
            dateSplitPicker.Enabled = false;
            companyTrainingCheckedBox.Enabled = false;

            // Set the mode as no split
            splitMode = TrainTestSplitMode.NoSplit;
        }

        private void randomTestSplitRadioButton_CheckedChanged( object sender, EventArgs e )
        {        
            // Disable the controls of other options and activate ours
            randomPercentageTextBox.Enabled = true;
            dateSplitPicker.Enabled = false;
            companyTrainingCheckedBox.Enabled = false;

            // Set the mode as random split
            splitMode = TrainTestSplitMode.RandomSplit;
        }

        private void dateTestSplitRadioButton_CheckedChanged( object sender, EventArgs e )
        {        
            // Disable the controls of other options and activate ours
            randomPercentageTextBox.Enabled = false;
            dateSplitPicker.Enabled = true;
            companyTrainingCheckedBox.Enabled = false;

            // Set the mode to date split
            splitMode = TrainTestSplitMode.DateSplit;
        }

        private void companyTestSplitRadioButton_CheckedChanged( object sender, EventArgs e )
        {
            // Disable the controls of other options and activate ours
            randomPercentageTextBox.Enabled = false;
            dateSplitPicker.Enabled = false;
            companyTrainingCheckedBox.Enabled = true;

            // Set the mode to company split
            splitMode = TrainTestSplitMode.TickerSplit;
        }

        // Perform the loading
        private void loadButton_Click( object sender, EventArgs e )
        {
            // First, in the case of random split, check the parameters
            if (splitMode == TrainTestSplitMode.RandomSplit)
            {
                if (!System.Int32.TryParse( randomPercentageTextBox.Text,
                    out randomSplitPercentage ))
                {
                    randomPercentageTextBox.Text = "";
                    MessageBox.Show( "The random percentage split must be an integer between 1 and 99" );
                    return;
                }
                if ((randomSplitPercentage < 1) ||
                    (randomSplitPercentage > 99))
                {
                    randomPercentageTextBox.Text = "";
                    MessageBox.Show( "The random percentage split must be an integer between 1 and 99" );
                    return;
                }
            }

            // Update the values of the other modes
            dateSplitCutoff = dateSplitPicker.Value;
            foreach (string ticker in companyTrainingCheckedBox.CheckedItems)
            {
                selectedTickers.Add( ticker );
            }
            
            // Now load the data
            switch (splitMode)
            {
                case TrainTestSplitMode.NoSplit:
                {
                    LoadNoSplit( );
                    break;
                }
                case TrainTestSplitMode.RandomSplit:
                {
                    LoadRandomSplit( );
                    break;
                }
                case TrainTestSplitMode.DateSplit:
                {
                    LoadDateSplit( );
                    break;
                }
                case TrainTestSplitMode.TickerSplit:
                {
                    LoadTickerSplit( );
                    break;
                }
                default:
                {
                    MessageBox.Show( "Please select a Train / Test split mode" );
                    return;
                }
            }

            if (trainData.Samples.Count == 0)
            {
                MessageBox.Show( "Error: No training data loaded" );
                return;
            }

            this.Close( );
        }

        // Load all the data without split, all to train, none to test
        private void LoadNoSplit( )
        {
            if (useQData)
            {
                Table<QLSample> qlData = dc.GetTable<QLSample>( );

                // Add all quarterly data to train, none to test
                foreach (QLSample sample in qlData)
                {
                    trainData.Samples.Add( sample );
                }
            }
            if (useYData)
            {
                Table<YLSample> ylData = dc.GetTable<YLSample>( );

                // Add all yearly data to train, none to test
                foreach (YLSample sample in ylData)
                {
                    trainData.Samples.Add( sample );
                }
            }
        }

        // Split the data randomly between train and test x% train (100-x)% test
        private void LoadRandomSplit( )
        {
            ClassificationData allData = new ClassificationData( );

            // Get all the data
            if (useQData)
            {
                Table<QLSample> qlData = dc.GetTable<QLSample>( );
                foreach (QLSample sample in qlData)
                {
                    allData.Samples.Add( sample );
                }
            }
            if (useYData)
            {
                Table<YLSample> ylData = dc.GetTable<YLSample>( );
                foreach (YLSample sample in ylData)
                {
                    allData.Samples.Add( sample );
                }
            }

            // Shuffle the data and split
            allData.Shuffle( );
            List<ClassificationData> splits =
                allData.Split( randomSplitPercentage );
            trainData = splits[0];
            testData = splits[1];
        }

        // Split the data based on the date, before for train, after for test
        private void LoadDateSplit( )
        {
            if (useQData)
            {
                Table<QLSample> qlData = dc.GetTable<QLSample>( );

                // Add samples before the date to train, other to test
                foreach (QLSample sample in qlData)
                {
                    if (sample.Date < dateSplitCutoff)
                    {
                        trainData.Samples.Add( sample );
                    }
                    else
                    {
                        testData.Samples.Add( sample );
                    }
                }
            }
            if (useYData)
            {
                Table<YLSample> ylData = dc.GetTable<YLSample>( );

                // Add samples before the date to train, other to test
                foreach (YLSample sample in ylData)
                {
                    if (sample.Date < dateSplitCutoff)
                    {
                        trainData.Samples.Add( sample );
                    }
                    else
                    {
                        testData.Samples.Add( sample );
                    }
                }
            }
        }

        // Split based on ticker, the selected tickers for train, the rest for test
        private void LoadTickerSplit( )
        {
            if (useQData)
            {
                Table<QLSample> qlData = dc.GetTable<QLSample>( );

                // Add samples in the ticker list to train, other to test
                foreach (QLSample sample in qlData)
                {
                    if (selectedTickers.Contains( sample.Ticker ))
                    {
                        trainData.Samples.Add( sample );
                    }
                    else
                    {
                        testData.Samples.Add( sample );
                    }
                }
            }
            if (useYData)
            {
                Table<YLSample> ylData = dc.GetTable<YLSample>( );

                // Add samples in the ticker list to train, other to test
                foreach (YLSample sample in ylData)
                {
                    if (selectedTickers.Contains( sample.Ticker ))
                    {
                        trainData.Samples.Add( sample );
                    }
                    else
                    {
                        testData.Samples.Add( sample );
                    }
                }
            }
        }

        // When cancelling just go back
        private void cancelButton_Click( object sender, EventArgs e )
        {
            this.Close( );
        }
    }
}
