using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UnitTest
    {
        public void Test_Deposit_ValidAmount() 
        {
            Program PObj=new Program(1000m);
            decimal newBalance=PObj.Deposit(500m);
            Assert.AreEqual(1500, newBalance);
        }
        public void Test_Deposit_NegativeAmount() 
        {
            Assert.AreEqual(
                "Deposit amount cannot be negative",
                Assert.Throws<Exception>(() => account.Deposit(-200m))!.Message
            );
        }
        public void Test_Withdraw_ValidAmount() 
        {
            Program account = new Program(1000m);

            // Act
            account.Withdraw(400m);

            // Assert (ONLY ONE ASSERT)
            Assert.AreEqual(600m, account.Balance);
        
        }
        public void Test_Withdraw_InsufficientFunds()
        {
            Program account = new Program(500m);

            // Act & Assert (ONLY ONE ASSERT)
            Assert.AreEqual(
                "Insufficient funds.",
                Assert.Throws<Exception>(() => account.Withdraw(800m))!.Message
            );
        }
    }
}
