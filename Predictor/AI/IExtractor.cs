namespace FinanceAI.AI
{
    // TODO: Remove? Who will do the feature extraction? Include in the samples?
    interface IExtractor
    {
        // Initialize the extraction
        void Initialize( string source );

        // Extract the features
        void Extract( 
            ISampleSelector s,      // true if the sample will be selected
            IFeatureSelector f );   // return a sample with the selected features

        // Return the extracted data
        ClassificationData Data { get; }
    }
}
