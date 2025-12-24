using System;
namespace CakeShop
{
    public class Cake
    {
        public string? flavour { set; get; }
        public int QuantityInKg { set; get; }
        double PricePerKg { set; get; }
        double discount { get; set; }


        public bool CakeOrder()
        {
            try
            {
                if (!true && (flavour == "Chocolate" || flavour == "Red Valvet" || flavour == "Vanilla"))
                {
                    throw new InvalidFlavourException("Flavour not available. Please select the available flavour");
                }
                else
                {
                    if (QuantityInKg <= 0)
                    {
                        throw new InvalidQuantityException("Quantity must be greater than zero");

                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                if (e is InvalidQuantityException)
                {
                    System.Console.WriteLine(e.Message);

                }
                else
                {
                    System.Console.WriteLine(e.Message);
                }
            }
            return true;


        }


        public void Input()
        {
            System.Console.WriteLine("=========Welcome to Cake World===========");
            System.Console.WriteLine("Enter Flavour");
            flavour=Console.ReadLine();
            System.Console.WriteLine("Enter Quantity in Kg");
            string? quantity=Console.ReadLine();

            QuantityInKg=Convert.ToInt32(quantity);

            System.Console.WriteLine("Enter Price/Kg");
            string? price=Console.ReadLine();

            PricePerKg=Convert.ToInt32(price);




        }

        public double CalculatePrice()
        {

            if (flavour == "Chocolate")
            {
                discount = 5;
            }
            else if (flavour == "Vanilla")
            {
                discount = 3;
            }
            else
            {
                discount = 10;

            }
            if(CakeOrder()){
                System.Console.WriteLine("Ordered Successfully");
            double TotalPrice = PricePerKg * QuantityInKg;

            double discountedPrice = TotalPrice - (TotalPrice * discount / 100);

            return discountedPrice;
            }
            else
            {
                return 0;
            }
        }
    }
}