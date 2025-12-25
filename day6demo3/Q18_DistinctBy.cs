
using System;
using System.Collections.Generic;

class DistinctBy
{
    public string[] Process(string[] a)
    {
        HashSet<string> seen=new();
        List<string> res=new();
        foreach(string s in a)
        {
            var p=s.Split(':');
            if(seen.Add(p[0])) res.Add(p[1]);
        }
        return res.ToArray();
    }
}
class Program
{
    static void Main()
    {
        DistinctBy d=new DistinctBy();
        Console.WriteLine(string.Join(",",d.Process(new[]{"1:A","1:B","2:C"})));
    }
}
