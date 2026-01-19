using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Program
{
    public static void Main()
    {
        Dictionary<int,int> EmployeeSalaries=new Dictionary<int,int>()
        {
            {1,20000},
            {4,40000},
            {5,15000}
        };
        List<int> Ids=new List<int>(){1,4,5};
        int totalSalary=Ids.Sum(id=>EmployeeSalaries.ContainsKey(id)?EmployeeSalaries[id]:0);
        Console.WriteLine(totalSalary);
    }   
}