using System;
class Heightcheck
{
	static void Main()
	{
	int height;	
height=Int32.Parse(Console.ReadLine());
if (height < 150)
{
    System.Console.WriteLine("Dwarf");
}else if(height>=150 && height < 165)
{
    System.Console.WriteLine("Average");
}else if(height>=165 && height < 190)
{
    System.Console.WriteLine("Tall");
}
else
{
    System.Console.WriteLine("Abnormal");
}
	}
}