
using System;

class Summary
{
    public string Get(int[] a)
    {
        int min = a[0], max = a[0], sum = 0;
        foreach (int x in a)
        {
            if (x < min) min = x;
            if (x > max) max = x;
            sum += x;
        }
        double avg = Math.Round((double)sum / a.Length, 2, MidpointRounding.AwayFromZero);
        return $"min={min}; max={max}; sum={sum}; avg={avg}";
    }
}
class Program
{
    static void Main()
    {
        Summary s = new Summary();
        Console.WriteLine(s.Get(new int[] { 2, 4, 6 }));
    }
}
