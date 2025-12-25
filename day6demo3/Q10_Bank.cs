
using System;

class Bank
{
    public int Final(int bal, int[] tx)
    {
        foreach (int t in tx)
            if (t >= 0 || bal + t >= 0) bal += t;
        return bal;
    }
}
class Program
{
    static void Main()
    {
        Bank b = new Bank();
        Console.WriteLine(b.Final(1000, new int[] { -200, 500, -1500 }));
    }
}
