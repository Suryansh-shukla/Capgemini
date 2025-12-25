
using System;

class Height
{
    public string Category(int h)
    {
        if (h < 150) return "Short";
        if (h < 180) return "Average";
        return "Tall";
    }
}
class Program
{
    static void Main()
    {
        Height h = new Height();
        Console.WriteLine(h.Category(175));
    }
}
