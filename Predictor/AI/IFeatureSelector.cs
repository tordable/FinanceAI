namespace FinanceAI.AI
{
    interface IFeatureSelector
    {
        // Select the appropriate features from the sample
        ISample Select( ISample sample );
    }

    // Select all features in the original sample
    public class FeatureSelectorAll : IFeatureSelector
    {
        public ISample Select( ISample sample )
        {
            return sample;
        }
    }

    // Select only the Description feature of the sample
    public class FeatureSelectorDescription : IFeatureSelector
    {
        public ISample Select( ISample sample )
        {
            return new SampleBasic( sample.Description );
        }
    }
}