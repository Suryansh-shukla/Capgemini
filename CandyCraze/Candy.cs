using System;
using System.Net.Http.Headers;
namespace CandyCraze
{
    class Candy
    {
        public string flavour{set;get;}
        public int quantity{set;get;}
        public int pricePerPiece{set;get;}
        public double totalPrice{set;get;}
        public double discountedPrice{set;get;}


        public bool ValidateCandyFlavour()
        {
            if (flavour == "Strawberry" || flavour == "Lemon" || flavour == "Mint")
            {
                return true;
            }
            return false;
        }

        public void Input()
        {
            System.Console.WriteLine("Enter Flavour");
            flavour=Console.ReadLine();



            System.Console.WriteLine("Enter Quantity");
            quantity=Convert.ToInt32(Console.ReadLine());


            System.Console.WriteLine("Enter Price Per Piece");
            pricePerPiece=Convert.ToInt32(Console.ReadLine());


            totalPrice=quantity*pricePerPiece;
        }

    }
}