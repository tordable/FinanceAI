namespace FinanceAI.AI
{
    public interface IRanker : IClassifier
    {
        // Return the rank of the sample, ignore the category
        double Rank( ISample sample );
        
        // Rank the instance for the given category
        double Rank( ISample sample, string category );
    }
}
