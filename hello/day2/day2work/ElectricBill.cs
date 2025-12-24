namespace ConsoleApp1;

public class ElectricBill
{
    int units;
    public void calculate()
    {
        Console.WriteLine("Enter the number of units consumed:");
        units = Convert.ToInt32(Console.ReadLine());
        double billAmount = 0;

        if (units <= 199)
        {
            billAmount = units * 1.20;
        }
        else if (units <= 400)
        {
            billAmount = (199 * 1.20) + ((units - 199) * 1.50);
        }
        else if(units <= 600)
        {
            billAmount = (199 * 1.20) + (201 * 1.50) + ((units - 400) * 1.80);
        }
        else{
            billAmount = (199 * 1.20) + (201 * 1.50) + (200 * 1.80) + ((units - 600) * 2.00);
        }

        Console.WriteLine($"Total Electric Bill: {billAmount}");
    }
}
