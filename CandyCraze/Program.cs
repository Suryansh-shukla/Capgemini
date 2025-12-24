using System;
using System.Security.Cryptography.X509Certificates;
namespace CandyCraze
{
    class Program
    {
        public static void Main()
        {
            Candy candy;
            candy = new Candy();
            candy.Input();
            CalculateDiscountedPrice(candy);
            System.Console.WriteLine(candy.discountedPrice);
            System.Console.WriteLine(candy.totalPrice);

        }

        
        public static Candy CalculateDiscountedPrice(Candy candy)
        {
            double discount = 0;
            switch (candy.flavour)
            {
                case "Strawberry":
                    {
                        discount = 15;
                        break;
                    }
                case "Lemon":
                    {
                        discount = 10;
                        break;

                    }
                case "Mint":
                    {
                        discount = 5;
                        break;
                    }
                default:
                    {
                        discount = 0;
                        break;
                    }

            }

            candy.discountedPrice=candy.totalPrice-(candy.totalPrice-(candy.totalPrice*discount/100));
            return candy;
        }
    }
}