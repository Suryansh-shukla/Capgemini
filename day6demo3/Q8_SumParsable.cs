
using System;

class TokenSum
{
    public int Sum(string[] a)
    {
        int s = 0;
        foreach (string x in a)
            if (int.TryParse(x, out int v)) s += v;
        return s;
    }
}
class Program
{
    static void Main()
    {
        TokenSum t = new TokenSum();
        Console.WriteLine(t.Sum(new string[] { "10", "x", "20" }));
    }
}
