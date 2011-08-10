using System;

namespace FinanceAI.Data
{
    public partial class Cashflow
    {
        public Cashflow( string ticker, DateTime date, char period, decimal[] values )
        {
            // Set values for the keys
            this.Ticker = ticker;
            this.Date = date;
            this.Period = period;

            // Set values for the features
            this.Net_Income_Starting_Line = values[0];
            this.Depreciation_Depletion = values[1];
            this.Amortization = values[2];
            this.Deferred_Taxes = values[3];
            this.Non_Cash_Items = values[4];
            this.Changes_in_Working_Capital = values[5];
            this.Cash_from_Operating_Activities = values[6];
            this.Capital_Expenditures = values[7];
            this.Other_Investing_Cash_Flow_Items__Total = values[8];
            this.Cash_from_Investing_Activities = values[9];
            this.Financing_Cash_Flow_Items = values[10];
            this.Total_Cash_Dividends_Paid = values[11];
            this.Issuance__Retirement__of_Stock__Net = values[12];
            this.Issuance__Retirement__of_Debt__Net = values[13];
            this.Cash_from_Financing_Activities = values[14];
            this.Foreign_Exchange_Effects = values[15];
            this.Net_Change_in_Cash = values[16];
            this.Cash_Interest_Paid__Supplemental = values[17];
            this.Cash_Taxes_Paid__Supplemental = values[18];

            OnCreated( );
        }
    }
}