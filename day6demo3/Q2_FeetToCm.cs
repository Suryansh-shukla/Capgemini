
using System;

class Converter
{
    public double Convert(int feet)
    {
        return Math.Round(feet * 30.48, 2, MidpointRounding.AwayFromZero);
    }
}
class Program
{
    static void Main()
    {
        Converter c = new Converter();
        Console.WriteLine(c.Convert(6));
    }
}
