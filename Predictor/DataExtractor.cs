using System;
using System.Data.Linq;

using FinanceAI.AI;
using FinanceAI.Data.Samples;

namespace FinanceAI.Predictor
{  
    class FinancialDataExtractor : IExtractor, IDisposable
    {
        // Connection with the database
        private DataContext dc;

        // Data extracted from the database
        private ClassificationData data = new ClassificationData( );

        public ClassificationData Data
        {
            get
            {
                return data;
            }
        }

        // Initialize the connection with the database
        public void Initialize( string source )
        {
            // TODO: Add checks in the source string
            dc = new DataContext( source );
        }

        // Performance extraction optimizations
        // Must be called explcitly as DatabaseCompanyExtractor, not IExtractor

        // Extract all labeled samples, all features
        public void Extract( SampleSelectorLabeled s, FeatureSelectorAll f )
        {
            throw new NotImplementedException( );
        }

        // Extract all non labeled samples, all features
        public void Extract( SampleSelectorNonLabeled s, FeatureSelectorAll f )
        {
            throw new NotImplementedException( );
        }

        // Extract data with the given generic criteria
        public void Extract( 
            ISampleSelector sampleSelector,
            IFeatureSelector featureSelector )
        {
            // TODO: Change to Q or Y data
            // Get the table of financial data
            Table<QLSample> qlSamples = dc.GetTable<QLSample>( );

            // copy the data to the list of training cases
            data = new ClassificationData( );
            foreach (QLSample sample in qlSamples)
            {
                // Apply the sample selection criteria
                if (sampleSelector.Select( sample ))
                {
                    // Apply the feature selection criteria
                    data.Samples.Add( featureSelector.Select( sample ) );
                }
            }
        }

        // TODO: Remove? We don't want to eliminate an external data context
        public void Dispose( )
        {
            // Close the connection
            dc.Dispose( );
        }
    }
}
