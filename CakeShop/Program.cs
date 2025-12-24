using System;
namespace CakeShop
{
    public class Program
    {
        public static void Main()
        {
            Cake cake=null;

            cake =new Cake();
            cake.Input();
            
            System.Console.WriteLine("After Discount Your Total is:{0}",cake.CalculatePrice());
        }

    }
}