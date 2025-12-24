using System;
using MyRetailLogic;
class SuperShopee
{
	static void Main()
	{
	int prod1;
	int prod2;
	int numResult;
	//Taking input Below

	Console.Write("Enter First Product Price:");
	prod1=Int32.Parse(Console.ReadLine());

	Console.Write("Enter Second Product Price:");
	prod2=Int32.Parse(Console.ReadLine());
	//BL
	RetailLogic rlObj=new RetailLogic();
	int disc=rlObj.CalcDiscount((prod1+prod2));
	numResult=(prod1+prod2)-disc;
	//print
	//Console.Write("The sum of {0} and {1} is {2}",prod1,prod2,numResult);
	Console.WriteLine("LPU Shop");
	Console.WriteLine("Price of Product 1 {0}",prod1);
	Console.WriteLine("Price of Product 2 {0}",prod2);
	Console.WriteLine("Total Price {0}",(prod1+prod2));
	Console.WriteLine("Discounted Price of products {0}",disc);
	Console.WriteLine("Price after Discount {0}",numResult);
	//Console.ReadLine();
	}
}
