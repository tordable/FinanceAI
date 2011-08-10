using System.Windows.Forms;

namespace FinanceAI.Predictor
{
    // This is the main form for the Predictor application
    public partial class MainForm : Form
    {
        public MainForm( PredictorControl p )
        {
            this.predictor = p;

            InitializeComponent( );

            this.loadTrainingButton.Click += new System.EventHandler(
                predictor.LoadTrainingData );
            this.parametersButton.Click += new System.EventHandler(
                predictor.SetParameters );
            this.trainButton.Click += new System.EventHandler(
                predictor.Train );
            this.loadAnalysisButton.Click += new System.EventHandler(
                predictor.LoadAnalysisData );
            this.analyzeButton.Click += new System.EventHandler(
                predictor.Analyze );
        }

        // Main control class
        private PredictorControl predictor;

        //Lists for all the tickers to analyze and results
        public ListBox TrainingList
        {
            get
            {
                return trainingList;
            }
        }

        public ListBox AnalysisList
        {
            get
            {
                return analysisList;
            }
        }

        public ListBox OverweightList
        {
            get
            {
                return overweightList;
            }
        }

        public ListBox UnderweightList
        {
            get
            {
                return underweightList;
            }
        }
    }
}
