
using System;

class GcdCalc
{
    public int GCD(int a, int b)
    {
        if (b == 0) return a;
        return GCD(b, a % b);
    }
}
class Program
{
    static void Main()
    {
        GcdCalc g = new GcdCalc();
        Console.WriteLine(g.GCD(48, 18));
    }
}
