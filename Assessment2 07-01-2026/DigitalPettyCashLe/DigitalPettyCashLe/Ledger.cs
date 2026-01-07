using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPettyCashLe
{
    class Ledger<T>where T: Transaction
    {
        List<T> transactions=new List<T>();
        public void AddEntry(T entry) 
        {
            transactions.Add(entry);
        }
        public List<T> GetTransactionsByDate(DateTime date)
        {
            List<T> result = new List<T>();
            foreach (T entry in transactions)
            {
                if (entry.TransactionDate.Date == date.Date)
                {
                    result.Add(entry);
                }
            }
            return result;
        }
        public double CalculateTotal()
        {
            double total = 0;
            foreach (T entry in transactions)
            {
                total += entry.Amount;
            }
            return total;
            }
        public List<T> GetAllTransactions()
        {
            return transactions;
        }
    }
}
