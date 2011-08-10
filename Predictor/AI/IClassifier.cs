namespace FinanceAI.AI
{
    public interface IClassifier
    {
        // Classify the given sample return the category and add it to the sample
        string Classify( ISample sample );

        // Classify the instance as either belonging to the given category or not
        bool Classify( ISample sample, string category );

        // Train the classifier on a given set of training data
        bool Train( ClassificationData trainingData );

        // Check if the classifier has already been trained, at least once
        bool IsTrained { get; }

        // Test the classifer and obtain performance metrics
        ClassifierPerformance Test( ClassificationData testData );
    }
}