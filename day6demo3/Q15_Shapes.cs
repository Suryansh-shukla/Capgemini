
using System;

abstract class Shape { public abstract double Area(); }

class Circle : Shape
{
    double r;
    public Circle(double r){this.r=r;}
    public override double Area()=>Math.PI*r*r;
}
class Program
{
    static void Main()
    {
        Shape s = new Circle(5);
        Console.WriteLine(Math.Round(s.Area(),2,MidpointRounding.AwayFromZero));
    }
}
