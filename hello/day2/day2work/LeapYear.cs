using System;
namespace day2work;
class LeapYear
{
    static void check()
    {
        int year;
        Console.Write("Enter a Year: ");
        year = Int32.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine("{0} is a Leap Year.", year);
        }
        else
        {
            Console.WriteLine("{0} is not a Leap Year.", year);
        }
    }
}