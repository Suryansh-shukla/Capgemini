using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPettyCashLe
{
    public class ExpenseTransaction:Transaction
    {
        public string Category {  get; set; }
        public override string GetSummary()
        {
            return $"Expense Transaction ID: {TransactionID}, Date: {TransactionDate.ToShortDateString()}, Amount: {Amount:C}, Category: {Category}, Description: {Description}";
        }
    }
}
