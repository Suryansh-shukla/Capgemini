using System;
using System.Collections.Generic;
using System.Linq;
public class Sale
{
    public string Region { get; set; }
    public string Category { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    
}
public class Program
{
    public static void Main()
    {
        List<Sale> sales = new List<Sale>
        {
            new Sale { Region = "North", Category = "Electronics", Amount = 1000, Date = new DateTime(2024, 1, 15) },
            new Sale { Region = "South", Category = "Clothing", Amount = 500, Date = new DateTime(2024, 2, 20) },
            new Sale { Region = "East", Category = "Groceries", Amount = 200, Date = new DateTime(2024, 3, 10) },
            new Sale { Region = "West", Category = "Furniture", Amount = 1500, Date = new DateTime(2024, 4, 5) }
        };

        var totalSalesByRegion = sales
            .GroupBy(s => s.Region)
            .Select(g => new { Region = g.Key, TotalAmount = g.Sum(s => s.Amount) });

        foreach (var item in totalSalesByRegion)
        {
            Console.WriteLine($"Region: {item.Region}, Total Sales: {item.TotalAmount}");
        }
        var totalSalesByCategory = sales
            .GroupBy(s => s.Category)
            .Select(g => new { Category = g.Key, TotalAmount = g.Sum(s => s.Amount) });
        foreach (var item in totalSalesByCategory)
        {
            Console.WriteLine($"Category: {item.Category}, Total Sales: {item.TotalAmount}");
        }
        var BestSalesDayOverall = sales
            .GroupBy(s => s.Date)
            .Select(g => new { Date = g.Key, TotalAmount = g.Sum(s => s.Amount) })
            .OrderByDescending(x => x.TotalAmount)
            .FirstOrDefault();
        if (BestSalesDayOverall != null)
        {
            Console.WriteLine($"Best Sales Day Overall: {BestSalesDayOverall.Date.ToShortDateString()}, Total Sales: {BestSalesDayOverall.TotalAmount}");
        }
    }
}