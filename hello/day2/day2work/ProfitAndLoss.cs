namespace ConsoleApp1;

public class ProfitAndLoss
{
    public void calculateProfitAndLoss()
    {
        Console.WriteLine("Enter the cost price:");
        int costPrice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the selling price:");
        int sellingPrice = Convert.ToInt32(Console.ReadLine());

        if (sellingPrice > costPrice)
        {
            int profit = sellingPrice - costPrice;
            Console.WriteLine($"Profit: {profit}");
        }
        else if (sellingPrice < costPrice)
        {
            int loss = costPrice - sellingPrice;
            Console.WriteLine($"Loss: {loss}");
        }
        else
        {
            Console.WriteLine("No profit, no loss.");
        }
    }
}