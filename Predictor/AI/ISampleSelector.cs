namespace FinanceAI.AI
{
    interface ISampleSelector
    {
        // Return true if the sample will be extracted
        bool Select( ISample sample );
    }

    // Select all samples
    public class SampleSelectorAll : ISampleSelector
    {
        public bool Select( ISample sample )
        {
            return true;
        }
    }

    // Select all labeled samples
    public class SampleSelectorLabeled : ISampleSelector
    {
        public bool Select( ISample sample )
        {
            if (sample.IsLabeled)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    // Select all unlabeled samples
    public class SampleSelectorNonLabeled : ISampleSelector
    {
        public bool Select( ISample sample )
        {
            if (sample.IsLabeled)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}