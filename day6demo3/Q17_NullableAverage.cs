
using System;

class AvgCalc
{
    public double? Avg(double?[] a)
    {
        double s=0; int c=0;
        foreach(var x in a) if(x!=null){s+=x.Value;c++;}
        if(c==0) return null;
        return Math.Round(s/c,2,MidpointRounding.AwayFromZero);
    }
}
class Program
{
    static void Main()
    {
        AvgCalc a = new AvgCalc();
        Console.WriteLine(a.Avg(new double?[]{1.5,null,2.5}));
    }
}
