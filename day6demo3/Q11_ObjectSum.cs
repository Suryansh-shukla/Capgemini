
using System;

class ObjectSum
{
    public int Sum(object[] a)
    {
        int s = 0;
        foreach (object o in a)
            if (o is int x) s += x;
        return s;
    }
}
class Program
{
    static void Main()
    {
        ObjectSum o = new ObjectSum();
        Console.WriteLine(o.Sum(new object[] { 1, "a", 3, true }));
    }
}
