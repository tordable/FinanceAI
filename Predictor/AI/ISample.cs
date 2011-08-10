using System.Collections.Generic;

namespace FinanceAI.AI
{
    public interface ISample
    {
        // Description of the sample
        string Description { get; }

        // List of all the features of the sample
        List<double> FeatureVector { get; }

        // Category of the sample
        string Category { get; }

        // Confidence or rank for the sample
        double Confidence { get; }

        // Return true if the sample is labeled
        bool IsLabeled { get; }
    }
}
