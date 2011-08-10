using System;
using System.Windows.Forms;

namespace FinanceAI.UI
{
    public partial class SetTrainParamsForm : Form
    {
        // Training parameters
        private bool initAtRandom;

        public bool InitAtRandom
        {
            get
            {
                return initAtRandom;
            }
        }

        private int numHiddenNodes;

        public int NumHiddenNodes
        {
            get
            {
                return numHiddenNodes;
            }
        }

        private double learningRate;

        public double LearningRate
        {
            get
            {
                return learningRate;
            }
        }

        private int maxRepetitions;

        public int MaxRepetitions
        {
            get
            {
                return maxRepetitions;
            }
        }

        // Constructor
        public SetTrainParamsForm( )
        {
            InitializeComponent( );

            // Set defaults
            initAtRandom = true;
            randomIniRadioButton.Checked = true;

            numHiddenNodes = 10;
            numHiddenNodesTextBox.Text = numHiddenNodes.ToString( );

            learningRate = 0.01;
            learningRateTextBox.Text = learningRate.ToString( );

            maxRepetitions = 1000;
            maxRepetitionsTextBox.Text = maxRepetitions.ToString( );
        }

        // Processing of the radio buttons

        private void randomIniRadioButton_CheckedChanged( object sender, EventArgs e )
        {
            if (randomIniRadioButton.Checked == true)
            {
                initAtRandom = true;
            }
            else
            {
                initAtRandom = false;
            }
        }

        private void zeroIniRadioButton_CheckedChanged( object sender, EventArgs e )
        {
            if (zeroIniRadioButton.Checked == true)
            {
                initAtRandom = false;
            }
            else
            {
                initAtRandom = true;
            }
        }

        // Check the parameters and return
        private void acceptButton_Click( object sender, EventArgs e )
        {
            // Check values for the number of nodes
            if (!System.Int32.TryParse( numHiddenNodesTextBox.Text,
                out numHiddenNodes ))
            {
                numHiddenNodesTextBox.Text = "";
                MessageBox.Show( "The number of nodes must be an integer greater than 0" );
                return;
            }
            if (numHiddenNodes <= 0)
            {
                numHiddenNodesTextBox.Text = "";
                MessageBox.Show( "The number of nodes must be an integer greater than 0" );
                return;
            }

            // Check the values for the learning rate
            if (!System.Double.TryParse( learningRateTextBox.Text,
                out learningRate ))
            {
                learningRateTextBox.Text = "";
                MessageBox.Show( "The learning rate must be a real number greater than 0 and lower than 1" );
                return;
            }
            if ((learningRate <= 0) || (learningRate >= 1))
            {
                learningRateTextBox.Text = "";
                MessageBox.Show( "The learning rate must be a real number greater than 0 and lower than 1" );
                return;
            }

            // Check the values for the max number of repetitions
            if (!System.Int32.TryParse( maxRepetitionsTextBox.Text,
                out maxRepetitions ))
            {
                maxRepetitionsTextBox.Text = "";
                MessageBox.Show( "The maximum number of repetitions must be an integer greater than 0" );
                return;
            }
            if (maxRepetitions <= 0)
            {
                maxRepetitionsTextBox.Text = "";
                MessageBox.Show( "The maximum number of repetitions must be an integer greater than 0" );
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
