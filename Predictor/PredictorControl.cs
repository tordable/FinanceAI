using System;
using System.IO;
using System.Collections.Generic;
using System.Data.Linq;
using System.Windows.Forms;

using FinanceAI.AI;
using FinanceAI.UI;

namespace FinanceAI.Predictor
{
    public class PredictorControl
    {
        // Main form of the application
        private MainForm form;

        public MainForm Form
        {
            set
            {
                form = value;
            }
        }

        // Current data context
        private DataContext dc;

        public DataContext DC
        {
            get
            {
                return dc;
            }
        }

        // Current classifier
        private IClassifier classifier;

        // Data
        private ClassificationData trainData = new ClassificationData( );

        private ClassificationData testData = new ClassificationData( );

        private ClassificationData analysisData = new ClassificationData( );

        private ClassificationData positiveResultData = new ClassificationData( );

        private ClassificationData negativeResultData = new ClassificationData( );

        // Training Data
        public List<string> TrainingDataDescriptions
        {
            get
            {
                return trainData.Descriptions;
            }
        }

        // Test Data
        public List<string> TestDataDescriptions
        {
            get
            {
                return testData.Descriptions;
            }
        }

        // Execution data
        public List<string> AnalysisDataDescriptions
        {
            get
            {
                return analysisData.Descriptions;
            }
        }

        // Positive Result data
        public List<string> PositiveResultDataDescriptions
        {
            get
            {
                return positiveResultData.Descriptions;
            }
        }

        // Negative Result data
        public List<string> NegativeResultDataDescriptions
        {
            get
            {
                return negativeResultData.Descriptions;
            }
        }

        // Initialize the data context for the database
        private void InitializeDataContext( )
        {
            // Try to find the DB file in the current path
            string dbPath = Path.Combine( Application.StartupPath, "FinancialData.mdf" );
            if (File.Exists( dbPath ))
            {
                dc = new DataContext(
                    @"Data Source=.\SQLEXPRESS;AttachDbFilename=" +
                    dbPath + @";Integrated Security=True;User Instance=True " );
            }
            else
            {
                // Ask the user for the location of the path
                OpenFileDialog dlg = new OpenFileDialog( );
                dlg.Title = "Load Financial Database";
                dlg.InitialDirectory = Application.StartupPath;
                dlg.Filter = "mdf files (*.mdf)|*.mdf";
                dlg.FilterIndex = 1;

                if (dlg.ShowDialog( ) == DialogResult.OK)
                {
                    dbPath = dlg.FileName;
                    dc = new DataContext(
                        @"Data Source=.\SQLEXPRESS;AttachDbFilename=" +
                        dbPath + @";Integrated Security=True;User Instance=True " );
                }
            }
        }

        // Constructor
        public PredictorControl( )
        {
            // Do nothing
        }

        // Load training data
        public void LoadTrainingData( object sender, EventArgs e )
        {
            // Initialize the data context
            InitializeDataContext( );
            if (dc == null)
            {
                MessageBox.Show( "Database file not found! Please load database first" );
                return;
            }

            // Show the loading training data window
            LoadTrainTestDataForm loadForm = new LoadTrainTestDataForm( dc );
            if (loadForm.ShowDialog( ) == DialogResult.OK)
            {
                // Get the data
                trainData = loadForm.TrainData;
                testData = loadForm.TestData;

                // Show the data on the screen
                form.TrainingList.Items.Clear( );
                foreach (string description in TrainingDataDescriptions)
                {
                    form.TrainingList.Items.Add( description );
                }
            }
            else
            {
                MessageBox.Show( "Please load the training data" );
                return;
            }
        }

        // Check if we have data avaliable to perform the training
        public bool HasTrainingData
        {
            get
            {
                if (trainData == null)
                {
                    return false;
                }
                if (trainData.Samples == null)
                {
                    return false;
                }
                if (trainData.Samples.Count == 0)
                {
                    return false;
                }
                return true;
            }
        }

        // Check if we have test avaliable to perform the validation
        public bool HasTestData
        {
            get
            {
                if (testData == null)
                {
                    return false;
                }
                if (testData.Samples == null)
                {
                    return false;
                }
                if (testData.Samples.Count == 0)
                {
                    return false;
                }
                return true;
            }
        }

        // Set the parameters for the classifier
        public void SetParameters( object sender, EventArgs e )
        {
            // Check that we have training data
            if (!HasTrainingData)
            {
                MessageBox.Show( "Please load training data first" );
                return;
            }

            // Show the parameters window and get the parameters
            SetTrainParamsForm paramsForm = new SetTrainParamsForm( );
            if (paramsForm.ShowDialog( ) == DialogResult.OK)
            {
                // The number of inputs equals the length of the feature vector
                int numInputs = trainData.Samples[0].FeatureVector.Count;

                // The remaining parameters are configurable
                int numHiddenNodes = paramsForm.NumHiddenNodes;
                double learningRate = paramsForm.LearningRate;
                int maxRepetitions = paramsForm.MaxRepetitions;

                // Create the classifier
                classifier = new SimpleNeuralNet1(
                    numInputs, numHiddenNodes, learningRate, maxRepetitions );
            }
            else
            {
                MessageBox.Show( "Please set the training parameters" );
                return;
            }
        }

        // Check if we already have the parameters for the classification
        public bool HasClassifierAvaliable
        {
            get
            {
                if (classifier == null)
                {
                    return false;
                }
                return true;
            }
        }

        // Trains the neural net using the training data
        public void Train( object sender, EventArgs e )
        {
            if (!HasTrainingData)
            {
                MessageBox.Show( "Please load training data first" );
                return;
            }
            if (!HasClassifierAvaliable)
            {
                MessageBox.Show( "Please set the training parameters first" );
                return;
            }

            // Normalize the training data
            trainData = trainData.NormalizeToRange( -1, 1 );

            // Train the classifier
            bool classifierTrained = classifier.Train( trainData );
            if (!classifierTrained)
            {
                MessageBox.Show( "Unable to train" );
                return;
            }

            // Test the classifier and show the results
            ClassifierPerformance perf;
            if (HasTestData)
            {
                // Normalize the test data
                testData = testData.NormalizeToRange( -1, 1 );

                // Test the classifier with the test data
                perf = classifier.Test( testData );
            }
            else
            {
                // Otherwise use the same training data
                perf = classifier.Test( trainData );
            }

            // Show the results
            TestResultsForm testForm = new TestResultsForm( perf );
            testForm.ShowDialog( );
        }

        public bool HasTrainedClassifier
        {
            get
            {
                if (classifier == null)
                {
                    return false;
                }

                return classifier.IsTrained;
            }
        }

        // Load the data to run the net against
        public void LoadAnalysisData( object sender, EventArgs e )
        {
            // The training data should be loaded first
            if (!HasTrainingData)
            {
                MessageBox.Show( "Please load training data first" );
                return;
            }

            // Show the loading analysis data window
            LoadAnalysisDataForm loadForm = new LoadAnalysisDataForm( dc );
            if (loadForm.ShowDialog( ) == DialogResult.OK)
            {
                // Get the data
                analysisData = loadForm.AnalysisData;

                // Show the analysis data on the screen
                form.AnalysisList.Items.Clear( );
                foreach (string description in AnalysisDataDescriptions)
                {
                    form.AnalysisList.Items.Add( description );
                }
            }
            else
            {
                MessageBox.Show( "Please load the data to analyze" );
                return;
            }
        }

        // Check if we have data avaliable to perform the analysis
        public bool HasAnalysisData
        {
            get
            {
                if (analysisData == null)
                {
                    return false;
                }
                if (analysisData.Samples == null)
                {
                    return false;
                }
                if (analysisData.Samples.Count == 0)
                {
                    return false;
                }
                return true;
            }
        }

        // Executes the net with the data provided and shows the results
        public void Analyze( object sender, EventArgs e )
        {
            if (!HasAnalysisData)
            {
                MessageBox.Show( "Please load analysis data first" );
                return;
            }
            if (!HasTrainedClassifier)
            {
                MessageBox.Show( "Please train the classifier first" );
                return;
            }

            // Normalize the analysis data
            analysisData = analysisData.NormalizeToRange( -1, 1 );

            // Analyze the data
            positiveResultData.Samples.Clear( );
            negativeResultData.Samples.Clear( );
            foreach (ISample sample in analysisData.Samples)
            {
                bool isGoodInvestment = classifier.Classify( sample, "good" );

                if (isGoodInvestment)
                {
                    positiveResultData.Samples.Add( sample );
                }
                else
                {
                    negativeResultData.Samples.Add( sample );
                }
            }

            // Show results
            form.OverweightList.Items.Clear( );
            foreach (string description in PositiveResultDataDescriptions)
            {
                form.OverweightList.Items.Add( description );
            }
            form.UnderweightList.Items.Clear( );
            foreach (string description in NegativeResultDataDescriptions)
            {
                form.UnderweightList.Items.Add( description );
            }
        }
    }
}
