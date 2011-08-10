using System;
using System.Collections.Generic;

using FinanceAI.AI;

namespace FinanceAI.Data.Samples
{
    public partial class YUSample : IFinancialSample
    {
        // Description MSFT Y 6/30/2008
        public string Description
        {
            get
            {
                return this.Ticker.Trim( ) + " Y " + this.Date.ToShortDateString( );
            }
        }

        // Ticker
        string IFinancialSample.Ticker
        {
            get
            {
                return this.Ticker;
            }
        }

        // Date
        DateTime IFinancialSample.Date
        {
            get
            {
                return this.Date;
            }
        }

        // Feature vector
        public List<double> FeatureVector
        {
            get
            {
                List<double> values = new List<double>( 107 );

                // TODO: Refactor?
                values.Add( (double)this.Revenue );
                values.Add( (double)this.Other_Revenue__Total );
                values.Add( (double)this.Total_Revenue );
                values.Add( (double)this.Cost_Of_Revenue__Total );
                values.Add( (double)this.Gross_Profit );
                values.Add( (double)this.Selling_General_Admin__Expenses__Total );
                values.Add( (double)this.Research___Development );
                values.Add( (double)this.Depreciation_Amortization );
                values.Add( (double)this.Interest_Expense_Income____Net_Operating );
                values.Add( (double)this.Unusual_Expense__Income_ );
                values.Add( (double)this.Other_Operating_Expenses__Total );
                values.Add( (double)this.Total_Operating_Expense );
                values.Add( (double)this.Operating_Income );
                values.Add( (double)this.Interest_Income_Expense___Net_Non_Operating );
                values.Add( (double)this.Gain__Loss__on_Sale_of_Assets );
                values.Add( (double)this.Other__Net );
                values.Add( (double)this.Income_Before_Tax );
                values.Add( (double)this.Income_After_Tax );
                values.Add( (double)this.Minority_Interest );
                values.Add( (double)this.Equity_In_Affiliates );
                values.Add( (double)this.Net_Income_Before_Extra__Items );
                values.Add( (double)this.Accounting_Change );
                values.Add( (double)this.Discontinued_Operations );
                values.Add( (double)this.Extraordinary_Item );
                values.Add( (double)this.Net_Income );
                values.Add( (double)this.Preferred_Dividends );
                values.Add( (double)this.Income_Available_to_Common_Excl__Extra_Items );
                values.Add( (double)this.Income_Available_to_Common_Incl__Extra_Items );
                values.Add( (double)this.Basic_Weighted_Average_Shares );
                values.Add( (double)this.Basic_EPS_Excluding_Extraordinary_Items );
                values.Add( (double)this.Basic_EPS_Including_Extraordinary_Items );
                values.Add( (double)this.Dilution_Adjustment );
                values.Add( (double)this.Diluted_Weighted_Average_Shares );
                values.Add( (double)this.Diluted_EPS_Excluding_Extraordinary_Items );
                values.Add( (double)this.Diluted_EPS_Including_Extraordinary_Items );
                values.Add( (double)this.Dividends_per_Share___Common_Stock_Primary_Issue );
                values.Add( (double)this.Gross_Dividends___Common_Stock );
                values.Add( (double)this.Net_Income_after_Stock_Based_Comp__Expense );
                values.Add( (double)this.Basic_EPS_after_Stock_Based_Comp__Expense );
                values.Add( (double)this.Diluted_EPS_after_Stock_Based_Comp__Expense );
                values.Add( (double)this.Depreciation__Supplemental );
                values.Add( (double)this.Total_Special_Items );
                values.Add( (double)this.Normalized_Income_Before_Taxes );
                values.Add( (double)this.Effect_of_Special_Items_on_Income_Taxes );
                values.Add( (double)this.Income_Taxes_Ex__Impact_of_Special_Items );
                values.Add( (double)this.Normalized_Income_After_Taxes );
                values.Add( (double)this.Normalized_Income_Avail_to_Common );
                values.Add( (double)this.Basic_Normalized_EPS );
                values.Add( (double)this.Diluted_Normalized_EPS );
                values.Add( (double)this.Cash___Equivalents );
                values.Add( (double)this.Short_Term_Investments );
                values.Add( (double)this.Cash_and_Short_Term_Investments );
                values.Add( (double)this.Accounts_Receivable___Trade__Net );
                values.Add( (double)this.Receivables___Other );
                values.Add( (double)this.Total_Receivables__Net );
                values.Add( (double)this.Total_Inventory );
                values.Add( (double)this.Prepaid_Expenses );
                values.Add( (double)this.Other_Current_Assets__Total );
                values.Add( (double)this.Total_Current_Assets );
                values.Add( (double)this.Property_Plant_Equipment__Total___Gross );
                values.Add( (double)this.Goodwill__Net );
                values.Add( (double)this.Intangibles__Net );
                values.Add( (double)this.Long_Term_Investments );
                values.Add( (double)this.Other_Long_Term_Assets__Total );
                values.Add( (double)this.Total_Assets );
                values.Add( (double)this.Accounts_Payable );
                values.Add( (double)this.Accrued_Expenses );
                values.Add( (double)this.Notes_Payable_Short_Term_Debt );
                values.Add( (double)this.Current_Port__of_LT_Debt_Capital_Leases );
                values.Add( (double)this.Other_Current_liabilities__Total );
                values.Add( (double)this.Total_Current_Liabilities );
                values.Add( (double)this.Long_Term_Debt );
                values.Add( (double)this.Capital_Lease_Obligations );
                values.Add( (double)this.Total_Long_Term_Debt );
                values.Add( (double)this.Total_Debt );
                values.Add( (double)this.Deferred_Income_Tax );
                values.Add( (double)this.Other_Liabilities__Total );
                values.Add( (double)this.Total_Liabilities );
                values.Add( (double)this.Redeemable_Preferred_Stock__Total );
                values.Add( (double)this.Preferred_Stock___Non_Redeemable__Net );
                values.Add( (double)this.Common_Stock__Total );
                values.Add( (double)this.Additional_Paid_In_Capital );
                values.Add( (double)this.Retained_Earnings__Accumulated_Deficit_ );
                values.Add( (double)this.Treasury_Stock___Common );
                values.Add( (double)this.Other_Equity__Total );
                values.Add( (double)this.Total_Equity );
                values.Add( (double)this.Total_Liabilities___Shareholders__Equity );
                values.Add( (double)this.Shares_Outs___Common_Stock_Primary_Issue );
                values.Add( (double)this.Total_Common_Shares_Outstanding );
                values.Add( (double)this.Depreciation_Depletion );
                values.Add( (double)this.Amortization );
                values.Add( (double)this.Deferred_Taxes );
                values.Add( (double)this.Non_Cash_Items );
                values.Add( (double)this.Changes_in_Working_Capital );
                values.Add( (double)this.Cash_from_Operating_Activities );
                values.Add( (double)this.Capital_Expenditures );
                values.Add( (double)this.Other_Investing_Cash_Flow_Items__Total );
                values.Add( (double)this.Cash_from_Investing_Activities );
                values.Add( (double)this.Financing_Cash_Flow_Items );
                values.Add( (double)this.Total_Cash_Dividends_Paid );
                values.Add( (double)this.Issuance__Retirement__of_Stock__Net );
                values.Add( (double)this.Issuance__Retirement__of_Debt__Net );
                values.Add( (double)this.Cash_from_Financing_Activities );
                values.Add( (double)this.Foreign_Exchange_Effects );
                values.Add( (double)this.Net_Change_in_Cash );
                values.Add( (double)this.Cash_Interest_Paid__Supplemental );
                values.Add( (double)this.Cash_Taxes_Paid__Supplemental );

                return values;
            }
        }

        // Category
        public string Category
        {
            get
            {
                return "none";
            }
        }

        // Confidence
        public double Confidence
        {
            get
            {
                return 0;
            }
        }

        // All YUSamples are not labeled
        public bool IsLabeled
        {
            get
            {
                return false;
            }
        }
    }
}