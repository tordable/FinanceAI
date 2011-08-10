using System;
using System.Collections.Generic;

namespace FinanceAI.AI
{
    // This class implements a simple neural net. It is a two layer perceptron
    // the first layer contains a modifiable number of nodes, the second layer
    // contains only one node. All features and outputs are double
    // It is completely connected, all inputs to all neurons in the hidden layer
    // The training mechanism for this net is backpropagation
    public sealed class SimpleNeuralNet1 : NeuralNet
    {
        // Neuron
        class Neuron
        {
            // Constructor
            public Neuron( List<Neuron> inputs, double bias )
            {
                this.inputs = inputs;
                this.bias = bias;
            }

            // List of inputs and bias
            protected List<Neuron> inputs;

            public List<Neuron> Inputs
            {
                get
                {
                    return inputs;
                }
                set
                {
                    inputs = value;
                }
            }

            // Weight of each input
            protected List<double> weights = new List<double>( );

            public List<double> Weights
            {
                get
                {
                    return weights;
                }
            }

            // Input bias
            protected double bias;

            public double Bias
            {
                get
                {
                    return bias;
                }
                set
                {
                    bias = value;
                }
            }

            // Function of the neuron
            public virtual double f( double value )
            {
                // Sigmoid function between -1 and 1
                return 2 / (1 + Math.Exp( -value )) - 1;
            }

            // Derivative of the function
            public virtual double fprime( double value )
            {
                // Derivative of a sigmoid between -1 and 1
                double exp = Math.Exp( -value );
                return 2 * exp / ((1 + exp) * (1 + exp));
            }

            // Weighted average of the inputs
            protected double sum;

            public double Sum
            {
                get
                {
                    return sum;
                }
            }

            // Output of the neuron
            protected double output;

            public double Output
            {
                get
                {
                    return output;
                }
            }

            public virtual void Update( )
            {
                double weightedSum = 0;

                // Compute the weighted sum of the inputs
                for (int i = 0; i < inputs.Count; i++)
                {
                    weightedSum += inputs[i].Output * weights[i];
                }

                // Add the bias
                weightedSum += bias;
                sum = weightedSum;

                // Return f of that
                output = f( sum );
            }

            // Load weights in (-1,1) for all inputs and bias
            public void LoadRandomWeights( )
            {
                Random random = new Random( );

                int NumberOfInputs = inputs.Count;

                for (int i = 0; i < NumberOfInputs; i++)
                {
                    weights.Insert( i, 2 * random.NextDouble( ) - 1 );
                }

                bias = 2 * random.NextDouble( ) - 1;
            }
        }

        sealed class InputNeuron : Neuron
        {
            public InputNeuron( double value )
                : base( null, 0 )
            {
                this.output = value;
            }

            public override void Update( )
            {
                // Do nothing
            }

            public void Update( double value )
            {
                this.output = value;
            }
        }

        sealed class FirstLayerNeuron : Neuron
        {
            // Constructor
            public FirstLayerNeuron( List<Neuron> inputs, double bias )
                : base( inputs, bias )
            {

            }

            // Computes the sensitivity of the unit
            private double Sensitivity( double error, SecondLayerNeuron output )
            {
                // The fprime times the sum of the weighed sensitivities of outputs
                // fprime(net) * sum(wji * sensitivity_k)
                double outputSensitivity = output.Sensitivity( error );
                int indexOfThisNeuron = output.Inputs.IndexOf( this );
                double weightOfThisNeuron = output.Weights[indexOfThisNeuron];

                return fprime( sum ) * outputSensitivity * weightOfThisNeuron;
            }

            // Backpropagate
            public void BackPropagate( double learningRate, double error,
                SecondLayerNeuron output )
            {
                // Obtain the sensitivity
                double sensitivity = Sensitivity( error, output );

                // Calculate the adjustments
                double[] adjustments = new double[inputs.Count + 1];

                // For the weights Dwjk = lr * sensitivity * input
                for (int i = 0; i < inputs.Count; i++)
                {
                    adjustments[i] = learningRate * sensitivity * inputs[i].Output;
                }

                // For the bias is the same, but the input is always 1
                adjustments[inputs.Count] = learningRate * sensitivity;

                // Apply adjustments to the weights for the inputs
                for (int i = 0; i < inputs.Count; i++)
                {
                    weights[i] += adjustments[i];
                }

                // Apply the adjustment to the bias
                bias += adjustments[inputs.Count];
            }
        }

        sealed class SecondLayerNeuron : Neuron
        {
            public SecondLayerNeuron( List<Neuron> inputs, double bias )
                : base( inputs, bias )
            {

            }

            // Computes the sensitivity of the unit
            // dk = -GJ/Gsumk, minus the partial of the error with respect to the sum
            public double Sensitivity( double error )
            {
                // error = tk - zk
                return error * fprime( sum );
            }

            // Backpropagate
            public void BackPropagate( double learningRate, double error )
            {
                // Obtain the sensitivity
                double sensitivity = Sensitivity( error );

                // Calculate the adjustments
                double[] adjustments = new double[inputs.Count + 1];

                // For the weights Dwjk = lr * sensitivity * input
                for (int i = 0; i < inputs.Count; i++)
                {
                    adjustments[i] = learningRate * sensitivity * inputs[i].Output;
                }

                // For the bias is the same, but the input is always 1
                adjustments[inputs.Count] = learningRate * sensitivity;

                // Apply adjustments to the weights for the inputs
                for (int i = 0; i < inputs.Count; i++)
                {
                    weights[i] += adjustments[i];
                }

                // Apply the adjustment to the bias
                bias += adjustments[inputs.Count];
            }
        }

        // Inputs to the neural net
        private List<Neuron> inputs;

        // Hidden layer of the neural net
        private List<Neuron> hiddenLayer;

        // Second layer of the neural net, one neuron
        private SecondLayerNeuron secondLayer;

        // Learning rate
        private double learningRate;

        // Max number of repetitions
        private int maxRepetitions;

        // True if the classifier has gone through training at least once
        private bool isTrained = false;

        // Contructor
        public SimpleNeuralNet1(
            int numberOfInputs,
            int numberOfHiddenNodes,
            double learningRate,
            int maxRepetitions )
        {
            this.learningRate = learningRate;
            this.maxRepetitions = maxRepetitions;

            // Initialize the inputs, set the value to 0
            inputs = new List<Neuron>( numberOfInputs );
            for (int i = 0; i < numberOfInputs; i++)
            {
                inputs.Insert( i, new InputNeuron( 0 ) );
            }

            // Initialize the hidden nodes, set the bias to 0
            hiddenLayer = new List<Neuron>( numberOfHiddenNodes );
            for (int i = 0; i < numberOfHiddenNodes; i++)
            {
                hiddenLayer.Insert( i, new FirstLayerNeuron( inputs, 0 ) );
            }

            // Initialize the second layer
            secondLayer = new SecondLayerNeuron( hiddenLayer, 0 );
        }

        /* 
         * Implementation of the IClassifier and IRanker interfaces
         */ 

        public override string Classify( ISample sample )
        {
            // This net uses only one category good/bad
            // the category is based on the rank

            double result = Rank( sample );

            if (result > 0)
            {
                return "good";
            }
            else
            {
                return "bad";
            }
        }

        public override bool Classify( ISample sample, string category )
        {
            string result = Classify( sample );

            if (category.Equals( result ))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override double Rank( ISample sample )
        {
            // Update the inputs with the sample
            for (int i = 0; i < inputs.Count; i++)
            {
                InputNeuron inputNeuron = (InputNeuron)inputs[i];
                inputNeuron.Update( sample.FeatureVector[i] );
            }

            // Update the hidden layer
            foreach (Neuron neuron in hiddenLayer)
            {
                neuron.Update( );
            }

            // Update the second layer
            secondLayer.Update( );

            // return the output
            return secondLayer.Output;
        }

        public override double Rank( ISample sample, string category )
        {
            // This net uses only one category good/bad
            return Rank( sample );
        }

        // Training algorithm, backpropagation
        public override bool Train( ClassificationData trainingData )
        {
            // Initialize the network, set random weights for the hidden layer
            for (int i = 0; i < hiddenLayer.Count; i++)
            {
                hiddenLayer[i].LoadRandomWeights( );
            }
            // Set random weights for the second layer
            secondLayer.LoadRandomWeights( );

            // Go through all the samples, until the the max number of repetitions
            int repetitions = 0;

            while (repetitions < maxRepetitions)
            {
                // Go through all samples
                for (int i = 0; i < trainingData.Samples.Count; i++)
                {
                    // Compute the predicted result and the error
                    double error;
                    string result = Classify( trainingData.Samples[i] );
                    string expected = trainingData.Samples[i].Category;

                    if ((result == "good") && (expected == "bad"))
                    {
                        error = -1.0;
                    }
                    else if ((result == "bad") && (expected == "good"))
                    {
                        error = 1.0;
                    }
                    else
                    {
                        // No error, continue to the next sample
                        error = 0.0;
                        continue;
                    }

                    // Backpropagate the second layer
                    secondLayer.BackPropagate( learningRate, error );

                    // Backpropagate the first layer
                    for (int j = 0; j < hiddenLayer.Count; j++)
                    {
                        FirstLayerNeuron neuron = (FirstLayerNeuron)hiddenLayer[j];
                        neuron.BackPropagate( learningRate, error, secondLayer );
                    }
                }

                // Next repetition
                repetitions++;
            }

            // Set as trained and return true if there are no errors
            isTrained = true;

            return true;
        }

        public override bool IsTrained
        {
            get
            {
                return isTrained;
            }
        }

        // Test the classifier
        public override ClassifierPerformance Test( ClassificationData testData )
        {
            ClassifierPerformance perf = new ClassifierPerformance( testData );

            foreach (ISample sample in testData.Samples)
            {
                // Obtain the extimated category
                string expectedCategory = Classify( sample );

                // Compare with the actual category
                string actualCategory = sample.Category;

                perf.Add( expectedCategory, actualCategory );
            }

            return perf;
        }
    }
}