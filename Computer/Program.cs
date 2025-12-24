using System;
namespace PracticeTest
{
    public class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("Select Option to proceed");
            System.Console.WriteLine("Press 1 for Desktop\nPress 2 for Laptop");
            string? input=Console.ReadLine();
            if(!int.TryParse(input,out int entry))
            {
                System.Console.WriteLine("Wrong entered values, Its not a number.");
                return;
            }
            switch (entry)
            {
                case 1:
                    {
                        Desktop desktop=new Desktop();
                        System.Console.WriteLine(desktop.DesktopPriceCalculator());
                        
                        break;
                    }
                case 2:
                    {
                        Laptop laptop=new Laptop();
                        System.Console.WriteLine(laptop.LaptopPriceCalculator());
                        
                        break;
                    }
            }

            
        }
    }
    
}