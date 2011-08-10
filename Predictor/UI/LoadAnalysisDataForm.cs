using System;
using System.Data.Linq;
using System.Windows.Forms;

// TODO: Remove dependency AI, only for classificationData
using FinanceAI.AI;
using FinanceAI.Data.Samples;

namespace FinanceAI.UI
{
    public partial class LoadAnalysisDataForm : Form
    {
        private DataContext dc;

        // Load parameters
        private bool useQData;

        private bool useYData;

        // Classification data
        private ClassificationData analysisData = new ClassificationData( );

        public ClassificationData AnalysisData
        {
            get
            {
                return analysisData;
            }
        }

        // Constructor
        public LoadAnalysisDataForm( DataContext dc )
        {
            this.dc = dc;
            InitializeComponent( );

            // Set defaults
            useQData = true;
            useQDataCheckBox.Checked = true;

            useYData = false;
            useYDataCheckBox.Checked = false;
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
        }

        // Perform the loading
        private void loadButton_Click( object sender, EventArgs e )
        {
            if (useQData)
            {
                Table<QUSample> quData = dc.GetTable<QUSample>( );

                // Add all quarterly unlabeled data to analysis
                foreach (QUSample sample in quData)
                {
                    analysisData.Samples.Add( sample );
                }
            }
            if (useYData)
            {
                Table<YUSample> yuData = dc.GetTable<YUSample>( );

                // Add all yearly unlabeled data to analysis
                foreach (YUSample sample in yuData)
                {
                    analysisData.Samples.Add( sample );
                }
            }

            // Check for errors
            if (analysisData.Samples.Count == 0)
            {
                MessageBox.Show( "Error: No analysis data loaded" );
                return;
            }

            this.Close( );
        }

        // When cancelling just go back
        private void cancelButton_Click( object sender, EventArgs e )
        {
            this.Close( );
        }
    }
}
