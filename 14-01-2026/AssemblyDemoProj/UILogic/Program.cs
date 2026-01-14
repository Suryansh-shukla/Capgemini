using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLibrary;

namespace UILogic
{
    [DoctorAttribute(Name ="Dr. Neha", CheckedOnDate ="2024-06-01")]
    //[DoctorAttribute(Name = "Dr. Amit", CheckedOnDate = "2024-06-02")]
    //[DoctorAttribute(Name = "Dr. Suresh", CheckedOnDate = "2024-06-03")]
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Enter First Number :");
            num1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number :");
            num2= Convert.ToInt32(Console.ReadLine());

            SomeLogic logic = new SomeLogic();

            
            int numResult=logic.AddMe(num1, num2);
            Console.WriteLine($"The Sum of {num1} and {num2} is : {numResult}");
            Console.ReadLine();
            DoctorAttribute[] attrs = (DoctorAttribute[])Attribute.GetCustomAttributes(typeof(Program), typeof(DoctorAttribute));
            if(attrs=null)
            {
                foreach(var attr in attrs)
                {
                    Console.WriteLine($"Checked By: {attr.Name} on Date: {attr.CheckedOnDate}");
                }

            }
        }
    }
}
