using System;

namespace FinanceAI.Data
{
    public partial class Balance
    {
        public Balance( string ticker, DateTime date, char period, decimal[] values )
        {
            // Set values for the keys
            this.Ticker = ticker;
            this.Date = date;
            this.Period = period;

            // Set values for the features
            this.Cash___Equivalents = values[0];
            this.Short_Term_Investments = values[1];
            this.Cash_and_Short_Term_Investments = values[2];
            this.Accounts_Receivable___Trade__Net = values[3];
            this.Receivables___Other = values[4];
            this.Total_Receivables__Net = values[5];
            this.Total_Inventory = values[6];
            this.Prepaid_Expenses = values[7];
            this.Other_Current_Assets__Total = values[8];
            this.Total_Current_Assets = values[9];
            this.Property_Plant_Equipment__Total___Gross = values[10];
            this.Goodwill__Net = values[11];
            this.Intangibles__Net = values[12];
            this.Long_Term_Investments = values[13];
            this.Other_Long_Term_Assets__Total = values[14];
            this.Total_Assets = values[15];
            this.Accounts_Payable = values[16];
            this.Accrued_Expenses = values[17];
            this.Notes_Payable_Short_Term_Debt = values[18];
            this.Current_Port__of_LT_Debt_Capital_Leases = values[19];
            this.Other_Current_liabilities__Total = values[20];
            this.Total_Current_Liabilities = values[21];
            this.Long_Term_Debt = values[22];
            this.Capital_Lease_Obligations = values[23];
            this.Total_Long_Term_Debt = values[24];
            this.Total_Debt = values[25];
            this.Deferred_Income_Tax = values[26];
            this.Minority_Interest = values[27];
            this.Other_Liabilities__Total = values[28];
            this.Total_Liabilities = values[29];
            this.Redeemable_Preferred_Stock__Total = values[30];
            this.Preferred_Stock___Non_Redeemable__Net = values[31];
            this.Common_Stock__Total = values[32];
            this.Additional_Paid_In_Capital = values[33];
            this.Retained_Earnings__Accumulated_Deficit_ = values[34];
            this.Treasury_Stock___Common = values[35];
            this.Other_Equity__Total = values[36];
            this.Total_Equity = values[37];
            this.Total_Liabilities___Shareholders__Equity = values[38];
            this.Shares_Outs___Common_Stock_Primary_Issue = values[39];
            this.Total_Common_Shares_Outstanding = values[40];

            OnCreated( );
        }
    }
}