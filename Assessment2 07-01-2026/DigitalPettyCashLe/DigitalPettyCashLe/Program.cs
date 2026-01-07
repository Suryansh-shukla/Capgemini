using DigitalPettyCashLe;
using System;
class Program
{
    public static void Main(string[] args)
    {
        Ledger<IncomeTransaction> incomeTransaction = new Ledger<IncomeTransaction>();
        Ledger<ExpenseTransaction> expenseTransaction = new Ledger<ExpenseTransaction>();
        while (true)
        {
            Console.WriteLine("Digital Petty Cash Ledger");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Adding Transactions...");
            Console.WriteLine("2. Generating Report...");
            Console.WriteLine("3. Exit");
            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("<------ Adding Transactions ------->");
                    Console.WriteLine("1. Income Transaction");
                    Console.WriteLine("2. Expense Transaction");
                    Console.WriteLine("Enter Your Choice : ");
                    int subchoice = Convert.ToInt32(Console.ReadLine());
                    switch (subchoice)
                    {
                        case 1:
                            Console.WriteLine("Enter Income Transaction Details:");
                            Console.WriteLine("Transaction ID:");
                            int incomeId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Amount:");
                            double incomeAmount = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Source:");
                            string? sourceInput = Console.ReadLine();
                            string source = sourceInput ?? string.Empty;
                            Console.WriteLine("Description:");
                            string incomeDescription = Console.ReadLine() ?? string.Empty;
                            incomeTransaction.AddEntry(new IncomeTransaction
                            {
                                TransactionID = incomeId,
                                TransactionDate = DateTime.Now,
                                Amount = incomeAmount,
                                Source = source,
                                Description = incomeDescription
                            });
                            break;
                        case 2:
                            Console.WriteLine("Enter Expense Transaction Details:");
                            Console.WriteLine("Transaction ID:");
                            int expenseId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Amount:");
                            double expenseAmount = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Category:");
                            string? categoryInput = Console.ReadLine();
                            string category = categoryInput ?? string.Empty;
                            Console.WriteLine("Description:");
                            string expenseDescription = Console.ReadLine() ?? string.Empty;
                            expenseTransaction.AddEntry(new ExpenseTransaction
                            {
                                TransactionID = expenseId,
                                TransactionDate = DateTime.Now,
                                Amount = expenseAmount,
                                Category = category,
                                Description = expenseDescription
                            });
                            break;
                        default:
                            Console.WriteLine("Invalid Choice. Please try again.");
                            continue;
                    }

                    break;
                case 2:
                    double totalIncome = incomeTransaction.CalculateTotal();
                    double totalExpense = expenseTransaction.CalculateTotal();
                    double balance = totalIncome - totalExpense;


                    Console.WriteLine($"Total Income: {totalIncome:C}");
                    DisplayTransactions(incomeTransaction);
                    Console.WriteLine($"Total Expense: {totalExpense:C}");
                    DisplayTransactions(expenseTransaction);
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("Petty Cash Balance Report");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("Total Income: {0:C}", totalIncome);
                    Console.WriteLine("Total Expense: {0:C}", totalExpense);
                    Console.WriteLine("Balance: {0:C}", balance);
                    Console.WriteLine("---------------------------");
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Please try again.");
                    continue;
            }
        }

         }
       

static void DisplayTransactions<T>(Ledger<T> ledger) where T : Transaction
{ 
        foreach (var transaction in ledger.GetAllTransactions())
        {
            Console.WriteLine(transaction.GetSummary());
        }
    }
}

