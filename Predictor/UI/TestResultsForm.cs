using System;
using System.Windows.Forms;

// To use the classifier performance
using FinanceAI.AI;

namespace FinanceAI.UI
{
    public partial class TestResultsForm : Form
    {
        // The performance of the classifier to show
        ClassifierPerformance perf;

        public TestResultsForm( ClassifierPerformance perf )
        {
            this.perf = perf;
            InitializeComponent( );

            // Show the results
            ShowResults( );
        }

        private void ShowResults( )
        {
            // Show machine learning metrics
            resultsTextBox.AppendText( "Classifier Performance Measures\n" );
            resultsTextBox.AppendText( "Number of Samples:" );
            resultsTextBox.AppendText( perf.NumSamples.ToString( ) + "\n" );
            resultsTextBox.AppendText( "Number of Categories:" );
            resultsTextBox.AppendText( perf.NumCategories.ToString( ) + "\n" );
            resultsTextBox.AppendText( "Micro precision: ");
            resultsTextBox.AppendText( perf.MicroPrecision.ToString( ) + "\n" );
            resultsTextBox.AppendText( "Micro recall: " );
            resultsTextBox.AppendText( perf.MicroRecall.ToString( ) + "\n" );
            resultsTextBox.AppendText( "Micro F1: " );
            resultsTextBox.AppendText( perf.MicroF1.ToString( ) + "\n" );
            resultsTextBox.AppendText( "Macro precision: " );
            resultsTextBox.AppendText( perf.MacroPrecision.ToString( ) + "\n" );
            resultsTextBox.AppendText( "Macro recall: " );
            resultsTextBox.AppendText( perf.MacroRecall.ToString( ) + "\n" );
            resultsTextBox.AppendText( "Macro F1: " );
            resultsTextBox.AppendText( perf.MacroF1.ToString( ) + "\n" );                
        }

        private void acceptButton_Click( object sender, EventArgs e )
        {
            this.Close( );
        }
    }
}
