// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ConsoleApp1;
System.Console.WriteLine("LPU Rocks!");

Student s1 = new Student(123,"Suryansh","Auraiya");
s1.DisplayDetails(s1);
s1=new Student(123,"Suryansh","Kanpur");
s1.DisplayDetails(s1);
string[] cities = {"Delhi","Noida","Gurgaon","Faridabad","Ghaziabad"};
int i=0;
foreach(var city in cities)
{
    System.Console.WriteLine(city);
}
while(i<cities.Length)
{
    System.Console.WriteLine(cities[i]);
    i++;
}
// while (true)
// {
//     int ch;
//     ch=Int32.Parse(Console.ReadLine());
//     switch (ch)
//     {
        
//     }
// }
