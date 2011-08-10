using System.Collections.Generic;

namespace FinanceAI.AI
{
    public class SampleBasic : ISample
    {
        public SampleBasic( )
        {
            // Empty feature vector
            description = "";
            featureVector = new List<double>( );
        }

        public SampleBasic( string description )
        {
            // Empty feature vector
            this.description = description;
            featureVector = new List<double>( );
        }

        public SampleBasic( string description, int featureVectorSize )
        {
            // Empty feature vector of the indicated size
            this.description = description;
            featureVector = new List<double>( featureVectorSize );
        }

        public SampleBasic( string description, params double[] features )
        {
            // Assigned feature vector
            this.description = description;
            featureVector = new List<double>( features );
        }

        public SampleBasic( string description, ICollection<double> features )
        {
            // Assigned feature vector
            this.description = description;
            featureVector = new List<double>( features );
        }

        // Textual description of the Sample
        private string description;

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        // Feature vector
        private List<double> featureVector;

        public List<double> FeatureVector
        {
            get
            {
                return featureVector;
            }
            set
            {
                featureVector = value;
            }
        }

        // Category of the sample
        private string category = null;

        public string Category
        {
            get
            {
                return category;
            }
        }

        // Confidence e [0,1]
        private double confidence = 0;

        public double Confidence
        {
            get
            {
                return confidence;
            }
        }

        public void Classify( string category )
        {  
            this.category = category;

            if (category == null)
            {
                // The category is not valid
                this.confidence = 0;
            }
            else
            {
                // Assign category with total confidence
                confidence = 1;
            }
        }

        public void Classify( string category, double confidence )
        {
            this.category = category;
            
            if (category == null)
            {
                // The category is not valid
                this.confidence = 0;
            }
            else if (confidence < 0)
            {
                // Must be a nonnegative number
                this.confidence = 0;
            }
            else if (confidence > 1)
            {
                // Must be less or equal than 1
                this.confidence = 1;
            }
            else
            {
                // just assign the value
                this.confidence = confidence;
            }
        }

        // The sample is labeled if it has a category
        public bool IsLabeled
        {
            get
            {
                if (category != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
