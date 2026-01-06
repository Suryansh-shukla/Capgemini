// See https://aka.ms/new-console-template for more information
using System;
namespace CustomePropertyDemo
{
    class Program
    {
        //struct Customer1 //Value type in Csharp
        //{
        //    public int ID { get; set; }
        //    public string Name { get; set; }
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Custom Property Demo");
            Customer custObj = new Customer();
            custObj.CustomerId = 1001;
            custObj.Name = "John Doe";
            Address billingAddress = new Address();
            billingAddress.FlatNo = 12;
            billingAddress.BuildingName = "Sunshine Apartments";
            billingAddress.Street = "Maple Street";
            billingAddress.Locality = "Downtown";
            billingAddress.City = "Metropolis";
            custObj.BillingAdd = billingAddress;
            Address shippingAddress = new Address();
            shippingAddress.FlatNo = 34;
            shippingAddress.BuildingName = "Greenwood Villas";
            shippingAddress.Street = "Oak Avenue";
            shippingAddress.Locality = "Uptown";
            shippingAddress.City = "Metropolis";
            custObj.ShipAddress = shippingAddress;
            Console.WriteLine($"Customer ID: {custObj.CustomerId}");
            Console.WriteLine($"Customer Name: {custObj.Name}");
            Console.WriteLine("Billing Address:");
            Console.WriteLine($"{custObj.BillingAdd.FlatNo}, {custObj.BillingAdd.BuildingName}, {custObj.BillingAdd.Street}, {custObj.BillingAdd.Locality}, {custObj.BillingAdd.City}");
            Console.WriteLine("Shipping Address:");
            Console.WriteLine($"{custObj.ShipAddress.FlatNo}, {custObj.ShipAddress.BuildingName}, {custObj.ShipAddress.Street}, {custObj.ShipAddress.Locality}, {custObj.ShipAddress.City}");
            custObj.MyOrders = new List<Orders>()
            { 
                new Orders{OrderID=1124,OrderDate=new DateTime(2001,12,22),Amount=14000},
                new Orders{OrderID=2076,OrderDate=new DateTime(2002,10,2),Amount=24000},
                new Orders{OrderID=8540,OrderDate=new DateTime(2002,07,27),Amount=54000},
                new Orders{OrderID=12122,OrderDate=new DateTime(2002,1,26),Amount=1500},
                new Orders{OrderID=1124,OrderDate=new DateTime(2003,1,14),Amount=140000},
            };
        }
    }
}