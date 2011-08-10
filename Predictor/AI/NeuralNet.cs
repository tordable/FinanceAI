namespace FinanceAI.AI
{
    public abstract class NeuralNet : IClassifier, IRanker
    {
        public abstract string Classify( ISample sample );

        public abstract bool Classify( ISample sample, string category );

        public abstract double Rank( ISample sample );

        public abstract double Rank( ISample sample, string category );
        
        public abstract bool Train( ClassificationData trainingData );

        public abstract bool IsTrained { get; }

        public abstract ClassifierPerformance Test( ClassificationData testData );
    }
}