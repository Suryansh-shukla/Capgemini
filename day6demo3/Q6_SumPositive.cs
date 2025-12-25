
using System;

class SumArray
{
    public int Sum(int[] a)
    {
        int s = 0;
        foreach (int x in a)
        {
            if (x == 0) break;
            if (x < 0) continue;
            s += x;
        }
        return s;
    }
}
class Program
{
    static void Main()
    {
        SumArray s = new SumArray();
        Console.WriteLine(s.Sum(new int[] { 5, -1, 4, 0, 10 }));
    }
}
