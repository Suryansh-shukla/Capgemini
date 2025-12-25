
using System;

class TimeFormatter
{
    public string Format(int sec)
    {
        return $"{sec / 60}:{(sec % 60):D2}";
    }
}
class Program
{
    static void Main()
    {
        TimeFormatter t = new TimeFormatter();
        Console.WriteLine(t.Format(125));
    }
}
