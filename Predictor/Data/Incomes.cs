using System;

namespace FinanceAI.Data
{
    public partial class Income
    {
        public Income( string ticker, DateTime date, char period, decimal[] values )
        {
            // Set values for the keys
            this.Ticker = ticker;
            this.Date = date;
            this.Period = period;

            // Set values for the features
            this.Revenue = values[0];
            this.Other_Revenue__Total = values[1];
            this.Total_Revenue = values[2];
            this.Cost_Of_Revenue__Total = values[3];
            this.Gross_Profit = values[4];
            this.Selling_General_Admin__Expenses__Total = values[5];
            this.Research___Development = values[6];
            this.Depreciation_Amortization = values[7];
            this.Interest_Expense_Income____Net_Operating = values[8];
            this.Unusual_Expense__Income_ = values[9];
            this.Other_Operating_Expenses__Total = values[10];
            this.Total_Operating_Expense = values[11];
            this.Operating_Income = values[12];
            this.Interest_Income_Expense___Net_Non_Operating = values[13];
            this.Gain__Loss__on_Sale_of_Assets = values[14];
            this.Other__Net = values[15];
            this.Income_Before_Tax = values[16];
            this.Income_After_Tax = values[17];
            this.Minority_Interest = values[18];
            this.Equity_In_Affiliates = values[19];
            this.Net_Income_Before_Extra__Items = values[20];
            this.Accounting_Change = values[21];
            this.Discontinued_Operations = values[22];
            this.Extraordinary_Item = values[23];
            this.Net_Income = values[24];
            this.Preferred_Dividends = values[25];
            this.Income_Available_to_Common_Excl__Extra_Items = values[26];
            this.Income_Available_to_Common_Incl__Extra_Items = values[27];
            this.Basic_Weighted_Average_Shares = values[28];
            this.Basic_EPS_Excluding_Extraordinary_Items = values[29];
            this.Basic_EPS_Including_Extraordinary_Items = values[30];
            this.Dilution_Adjustment = values[31];
            this.Diluted_Weighted_Average_Shares = values[32];
            this.Diluted_EPS_Excluding_Extraordinary_Items = values[33];
            this.Diluted_EPS_Including_Extraordinary_Items = values[34];
            this.Dividends_per_Share___Common_Stock_Primary_Issue = values[35];
            this.Gross_Dividends___Common_Stock = values[36];
            this.Net_Income_after_Stock_Based_Comp__Expense = values[37];
            this.Basic_EPS_after_Stock_Based_Comp__Expense = values[38];
            this.Diluted_EPS_after_Stock_Based_Comp__Expense = values[39];
            this.Depreciation__Supplemental = values[40];
            this.Total_Special_Items = values[41];
            this.Normalized_Income_Before_Taxes = values[42];
            this.Effect_of_Special_Items_on_Income_Taxes = values[43];
            this.Income_Taxes_Ex__Impact_of_Special_Items = values[44];
            this.Normalized_Income_After_Taxes = values[45];
            this.Normalized_Income_Avail_to_Common = values[46];
            this.Basic_Normalized_EPS = values[47];
            this.Diluted_Normalized_EPS = values[48];

            OnCreated( );
        }
    }
}