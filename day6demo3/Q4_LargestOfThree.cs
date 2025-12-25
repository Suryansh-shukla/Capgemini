
using System;

class Largest
{
    public int Find(int a, int b, int c)
    {
        return (a > b && a > c) ? a : (b > c ? b : c);
    }
}
class Program
{
    static void Main()
    {
        Largest l = new Largest();
        Console.WriteLine(l.Find(10, 20, 15));
    }
}
