using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPettyCashLe
{
    public abstract class Transaction:IReportable
    {
        public int TransactionID {  get; set; }
        public DateTime TransactionDate {  get; set; }
        public double Amount {  get; set; }
        public string Description {  get; set; }
        public abstract string GetSummary();
    }
}
