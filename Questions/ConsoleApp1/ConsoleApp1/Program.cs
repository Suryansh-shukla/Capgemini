using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public decimal Balance { get; set; }

        public Program(decimal balance)
        {
            this.Balance = balance; 
        }
        public decimal Deposit(decimal amount)
        {
            // Validate input and update balance; do not use an empty try block.
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount cannot be negative");
            }

            this.Balance += amount;
            return this.Balance;
        }
        public void Withdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("Insufficient funds)");
            }
            this.Balance -= amount;
        }
        static void Main(string[] args)
        {

        }
    }
}
