using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FinanceAI.AI;

namespace FinanceAI.Data.Samples
{
    interface IFinancialSample : ISample
    {
        // Ticker of the company that the sample refers to
        string Ticker { get; }

        // Date of the sample
        DateTime Date { get; }
    }
}
