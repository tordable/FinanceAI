using System;
using System.Collections.Generic;

namespace FinanceAI.AI
{
    // TODO: Move it out of AI and into Data?
    // TODO: Make it ICollection<ISample>
    //    Add all the corresponding methods to add and enumerate

    // This class contains the samples to feed the classifier
    // Also it contains methods to manipulate and process those samples
    public class ClassificationData
    {
        // A list of classification samples
        private List<ISample> samples = new List<ISample>();

        public List<ISample> Samples
        {
            get
            {
                return samples;
            }
        }

        public List<string> Descriptions
        {
            get
            {
                List<string> descriptions = new List<string>( );
                foreach (ISample sample in Samples)
                {
                    descriptions.Add( sample.Description );
                }
                return descriptions;
            }
        }

        // Labeled data / Non labeled data
        public bool HasOnlyLabeledData
        {
            get
            {
                foreach (ISample sample in samples)
                {
                    if (!sample.IsLabeled)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        public bool HasOnlyNonLabeledData
        {
            get
            {
                foreach (ISample sample in samples)
                {
                    if (sample.IsLabeled)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        /*
         * Operations that affect all the samples as a whole
         */

        // Normalize the data by range
        // Each feature will have new values in the range
        public ClassificationData NormalizeToRange( double lower, double upper )
        {
            // Check the boundaries of the target interval
            if (upper <= lower)
            {
                throw new ArgumentException( );
            }

            // Initialize the ranges
            int numFeatures = samples[0].FeatureVector.Count;
            double[] minFeatureValues = new double[numFeatures];
            double[] maxFeatureValues = new double[numFeatures];
            for (int i = 0; i < numFeatures; i++)
            {
                minFeatureValues[i] = double.MaxValue;
                maxFeatureValues[i] = double.MinValue;
            }

            // First calculate the range of the features
            foreach (ISample sample in samples)
            {
                for (int iFeature = 0; iFeature < numFeatures; iFeature++)
                {
                    // Update the min
                    if (sample.FeatureVector[iFeature] < minFeatureValues[iFeature])
                    {
                        minFeatureValues[iFeature] = sample.FeatureVector[iFeature];
                    }

                    // Update the max
                    if (sample.FeatureVector[iFeature] > maxFeatureValues[iFeature])
                    {
                        maxFeatureValues[iFeature] = sample.FeatureVector[iFeature];
                    }
                }
            }

            // To prevent division by zero, if max = min all features are equal
            // to the min, if max -> max + 1 the tranform values are the same
            for (int i = 0; i < numFeatures; i++)
            {
                if (maxFeatureValues[i] == minFeatureValues[i])
                {
                    maxFeatureValues[i]++;
                }
            }

            // Create the new samples
            ClassificationData result = new ClassificationData( );
            for (int i = 0; i < samples.Count; i++)
            {
                SampleBasic sample = new SampleBasic( );
                sample.Description = samples[i].Description;
                sample.FeatureVector = new List<double>( numFeatures );
                sample.Classify( samples[i].Category );
                result.Samples.Add( sample );
            }

            // Obtain the new feature values by a linear transformation
            // feature = (original - min) / (max - min) goes from 0 to 1
            // feature = original * (upper - lower) + lower goes from lower to upper
            double featureValue;
            for (int iSample = 0; iSample < samples.Count; iSample++)
            {
                for (int iFeature = 0; iFeature < numFeatures; iFeature++)
                {
                    featureValue = samples[iSample].FeatureVector[iFeature];
                    
                    // Transform to [0,1]
                    featureValue = (featureValue - minFeatureValues[iFeature]) /
                        (maxFeatureValues[iFeature] - minFeatureValues[iFeature]);

                    // Transform to [lower,upper]
                    featureValue = featureValue * (upper - lower) + lower;

                    result.Samples[iSample].FeatureVector.Insert( iFeature, featureValue );
                }
            }

            return result;
        }

        // TODO: Other normalization methods

        // Shuffle the data randomly
        public void Shuffle( )
        {
            Random random = new Random( );
            int randomPosition;
            ISample randomSample;

            for (int position = 0; position < this.Samples.Count; position++)
            {
                // Get the new position
                randomPosition = random.Next( position, this.Samples.Count );
                if (randomPosition != position)
                {
                    // And switch the two elements
                    randomSample = this.Samples[randomPosition];
                    this.Samples[randomPosition] = this.Samples[position];
                    this.Samples[position] = randomSample;
                }
            }

            return;
        }

        /*
         * Split the data into multiple groups
         */ 

        // Split on percentage, give % param to the first one
        // This method does *not* shuffle the data
        public List<ClassificationData> Split( int percentage )
        {
            List<ClassificationData> result = new List<ClassificationData>( 2 );

            // For <= 0 percentage, the second gets all
            if (percentage <= 0)
            {
                result.Add( new ClassificationData( ) );
                result.Add( this );
            }

            // For >= 100 percentage, the first gets all
            if (percentage >= 100)
            {
                result.Add( this );
                result.Add( new ClassificationData( ) );
            }

            // For any given percentage, assign correspondingly       
            result.Add( new ClassificationData( ) );
            result.Add( new ClassificationData( ) );

            int splitSize = (int)((double)(this.Samples.Count * percentage) / 100);

            for (int i = 0; i < this.Samples.Count; i++)
            {
                if (i < splitSize)
                {
                    result[0].Samples.Add( this.Samples[i] );
                }
                else
                {
                    result[1].Samples.Add( this.Samples[i] );
                }
            }

            return result;
        }

        // Split the data, assign a certain percentage to each split
        public List<ClassificationData> Split( double percentFirst, 
            params double[] percentOthers )
        {
            throw new NotImplementedException( );
        }

        // Split on fixed size buckets
        public List<ClassificationData> Split( params int[] splitSizes )
        {
            throw new NotImplementedException( );
        }
    }
}
