using System;

namespace FinanceAI.Data
{
    public partial class Quote
    {
        public Quote( string ticker, DateTime date, decimal[] values )
        {
            // Set values for the keys
            this.Ticker = ticker;
            this.Date = date;

            // Set values for the features
            this.Open = values[0];
            this.High = values[1];
            this.Low = values[2];
            this.Close = values[3];
            this.Volume = values[4];

            OnCreated( );
        }
    }
}
