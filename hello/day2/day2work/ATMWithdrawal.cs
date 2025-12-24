namespace ConsoleApp1;
//ATM Withdrawal: Nested if to check: 1. Card inserted, 2. Pin valid, 3. Balance sufficient.
public class ATMWithdrawal
{
    public void withdrawMoney()
    {
        Console.WriteLine("Enter the amount to withdraw:");
        int amount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the card number:");
        string cardNumber = Console.ReadLine();
        Console.WriteLine("Enter the pin:");
        string pin = Console.ReadLine();
        Console.WriteLine("Enter the balance:");
        int balance = Convert.ToInt32(Console.ReadLine());

        if (cardNumber == "1234567890123456")
        {
            if (pin == "1234")
            {
                if (amount <= balance)
                {
                    Console.WriteLine($"You have withdrawn {amount} successfully.");
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }
            else
            {
                Console.WriteLine("Invalid pin.");
            }
        }
        else
        {
            Console.WriteLine("Invalid card number.");
        }
    }
}
