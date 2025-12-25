
using System;
using System.Collections.Generic;

class Store
{
    Dictionary<string, int> data = new();

    public int Get(string k) => data.ContainsKey(k) ? data[k] : 0;
    public void Set(string k, int v) => data[k] = v;
    public void Add(string k, int d) => data[k] = Get(k) + d;
}
class Program
{
    static void Main()
    {
        Store s = new Store();
        s.Set("a", 5);
        s.Add("a", 3);
        Console.WriteLine(s.Get("a"));
    }
}
