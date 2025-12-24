using System;
class greater
{
	static void Main()
	{
	int first_number;
	int second_number;
	int third_number;
	Console.Write("Enter First Number : ");
	first_number=Int32.Parse(Console.ReadLine());
	Console.Write("Enter First Number : ");
	second_number=Int32.Parse(Console.ReadLine());
	Console.Write("Enter First Number : ");
	third_number=Int32.Parse(Console.ReadLine());
	if(first_number>second_number && first_number>third_number)
	{
	Console.Write("Greatest among Three Numbers is {0}",first_number);
	}
else if(second_number>third_number &&second_number>first_number)
{
	Console.Write("Greatest amoung Three Numbers is {0}",second_number);
}
else
{
Console.Write("Greatest among Three Numbers is {0}",third_number);
}
}
}