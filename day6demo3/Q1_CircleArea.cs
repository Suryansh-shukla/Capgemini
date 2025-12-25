
using System;

class Circle
{
    public double Radius;
    public double Area()
    {
        return Math.Round(Math.PI * Radius * Radius, 2, MidpointRounding.AwayFromZero);
    }
}
class Program
{
    static void Main()
    {
        Circle c = new Circle { Radius = 5 };
        Console.WriteLine(c.Area());
    }
}
