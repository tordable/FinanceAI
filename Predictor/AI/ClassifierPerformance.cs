using System;
using System.Collections.Generic;

namespace FinanceAI.AI
{
    // Result of the classification of a set of samples into categories
    public class ClassifierPerformance
    {
        // Data to test the classification
        private ClassificationData data;

        // Number of categories of the classification
        private int numCategories;

        public int NumCategories
        {
            get
            {
                return numCategories;
            }
        }

        // Number of samples
        private int numSamples;

        public int NumSamples
        {
            get
            {
                return numSamples;
            }
        }

        // Categories of the classification
        private List<string> categories = new List<string>( );

        // Matrix with the classification resutls
        private int[,] results;

        // Constructor
        public ClassifierPerformance( ClassificationData classificationData )
        {
            this.data = classificationData;

            // Count the number of distinct categories
            numSamples = data.Samples.Count;
            foreach(ISample sample in data.Samples)
            {
                if (!categories.Contains( sample.Category ))
                {
                    categories.Add( sample.Category );
                }
            }
            this.numCategories = categories.Count;
            if (numCategories == 0)
            {
                throw new ArgumentException( );
            }

            // Initialize the results matrix
            results = new int[numCategories, numCategories];
            for (int i = 0; i < numCategories; i++)
            {
                for (int j = 0; j < numCategories; j++)
                {
                    results[i, j] = 0;
                }
            }
        }

        // Update the results with each sample
        public void Add( string expectedCategory, string predictedCategory )
        {
            int expected = categories.IndexOf( expectedCategory );
            int predicted = categories.IndexOf( predictedCategory );

            results[expected, predicted]++;
        }

        // Micro averaged metrics (averaged per class)

        // TODO: Add caching of values? Compute all metrics at once?

        public double MicroPrecision
        {
            get
            {
                // TODO: Switch to int
                double correct = 0.0;
                double incorrect = 0.0;

                // if predicted = expected it is correct, otherwise false
                // Gives equal weight to each case
                for (int i = 0; i < numCategories; i++)
                {
                    for (int j = 0; j < numCategories; j++)
                    {
                        if (i == j)
                        {
                            correct += results[i, j];
                        }
                        else
                        {
                            incorrect += results[i, j];
                        }
                    }
                }

                // micro precission = correct / all cases
                if (correct + incorrect != 0)
                {
                    return correct / (correct + incorrect);
                }
                else
                {
                    return 0;
                }
            }
        }

        public double MicroRecall
        {
            get
            {
                // micro recall = correct / all cases = micro precission
                return MicroPrecision;
            }
        }

        public double MicroF1
        {
            get
            {
                // F1 = p * r, but micro r = micro p
                double p = MicroPrecision;
                return p * p;
            }
        }

        // Macro averaged netrics (averaged per case)

        // TODO: Add caching of values?

        public double MacroPrecision
        {
            get
            {
                // Obtain the precission for each category (classification assigned)
                double[] precision = new double[numCategories];
                for (int j = 0; j < numCategories; j++)
                {
                    precision[j] = 0;
                }

                // For each classification
                for (int j = 0; j < numCategories; j++)
                {
                    // Add all the elements classified in the category
                    for (int i = 0; i < numCategories; i++)
                    {
                        precision[j] += results[i, j];
                    }

                    // The precission is correct / total classified in the category
                    if (precision[j] != 0)
                    {
                        precision[j] = results[j, j] / precision[j];
                    }
                    else
                    {
                        precision[j] = 0;
                    }
                }

                // Calculate the average of the precissions
                double macroPrecision = 0.0;
                for (int j = 0; j < numCategories; j++)
                {
                    macroPrecision += precision[j];
                }
                macroPrecision = macroPrecision / numCategories;

                return macroPrecision;
            }
        }

        public double MacroRecall
        {
            get
            {
                // Obtain the recall for each category
                double[] recall = new double[numCategories];
                for (int i = 0; i < numCategories; i++)
                {
                    recall[i] = 0;
                }

                // For each category
                for (int i = 0; i < numCategories; i++)
                {
                    // Add all the elements from that category
                    for (int j = 0; j < numCategories; j++)
                    {
                        recall[i] += results[i, j];
                    }

                    // The recall is correct / total for that category
                    if (recall[i] != 0)
                    {
                        recall[i] = results[i, i] / recall[i];
                    }
                    else
                    {
                        recall[i] = 0;
                    }
                }

                // Calculate the average of the recall
                double macroRecall = 0.0;
                for (int i = 0; i < numCategories; i++)
                {
                    macroRecall += recall[i];
                }
                macroRecall = macroRecall / numCategories;

                return macroRecall;
            }
        }

        public double MacroF1
        {
            get
            {
                return MacroPrecision * MacroRecall;
            }
        }
    }
}