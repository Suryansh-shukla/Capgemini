
using System;

abstract class Employee { public abstract decimal Pay(); }

class Hourly : Employee
{
    decimal r, h;
    public Hourly(decimal r, decimal h){this.r=r;this.h=h;}
    public override decimal Pay()=>r*h;
}
class Program
{
    static void Main()
    {
        Employee e = new Hourly(100, 8);
        Console.WriteLine(e.Pay());
    }
}
