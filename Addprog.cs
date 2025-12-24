using System;
class AddProg
{
	static void Main()
	{
	int num1;
	int num2;
	int numResult;
	//Taking input Below

	Console.Write("Enter First Number:");
	num1=Int32.Parse(Console.ReadLine());

	Console.Write("Enter Second Number:");
	num2=Int32.Parse(Console.ReadLine());
	//BL
	int disc=(num1+num2)*10/100;
	numResult=(num1+num2)-disc;
	//print
	//Console.Write("The sum of {0} and {1} is {2}",num1,num2,numResult);
	Console.WriteLine("LPU Shop");
	Console.WriteLine("Price of Product 1 {0}",num1);
	Console.WriteLine("Price of Product 2 {0}",num2);
	Console.WriteLine("Total Price {0}",(num1+num2));
	Console.WriteLine("Price after Discount {0}",numResult);
	//Console.ReadLine();
	}
}
