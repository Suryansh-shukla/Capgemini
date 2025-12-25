
using System;

class Table
{
    public int[] Row(int n, int upto)
    {
        int[] r = new int[upto];
        for (int i = 1; i <= upto; i++) r[i - 1] = n * i;
        return r;
    }
}
class Program
{
    static void Main()
    {
        Table t = new Table();
        Console.WriteLine(string.Join(",", t.Row(3, 5)));
    }
}
