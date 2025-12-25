
using System;
using System.Linq;
using System.Text.Json;

record Student(string Name,int Score);

class Program
{
    static void Main()
    {
        string[] a={"A:90","B:80","C:95"};
        var res=a.Select(x=>{
            var p=x.Split(':');return new Student(p[0],int.Parse(p[1]));
        }).Where(s=>s.Score>=85).OrderByDescending(s=>s.Score).ThenBy(s=>s.Name);
        Console.WriteLine(JsonSerializer.Serialize(res));
    }
}
