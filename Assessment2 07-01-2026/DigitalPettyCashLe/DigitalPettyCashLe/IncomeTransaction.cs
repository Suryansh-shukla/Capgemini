using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPettyCashLe
{
    class IncomeTransaction: Transaction
    {
        public string Source {  get; set; }
        public override string GetSummary()
        {
            return $"Income Transaction ID: {TransactionID}, Date: {TransactionDate.ToShortDateString()}, Amount: {Amount:C}, Source: {Source}, Description: {Description}";
        }
    }
}
