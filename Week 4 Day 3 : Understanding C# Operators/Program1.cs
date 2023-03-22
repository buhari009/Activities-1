using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter branding expenses");
        double brandingExpenses = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter travel expenses");
        double travelExpenses = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter food expenses");
        double foodExpenses = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter logistics expenses");
        double logisticsExpenses = double.Parse(Console.ReadLine());

        double totalExpenses = brandingExpenses + travelExpenses + foodExpenses + logisticsExpenses;

        Console.WriteLine("Total expenses: Rs.{0:f2}", totalExpenses);
        Console.WriteLine("Branding expenses percentage: {0:f2}%", (brandingExpenses / totalExpenses) * 100);
        Console.WriteLine("Travel expenses percentage: {0:f2}%", (travelExpenses / totalExpenses) * 100);
        Console.WriteLine("Food expenses percentage: {0:f2}%", (foodExpenses / totalExpenses) * 100);
        Console.WriteLine("Logistics expenses percentage: {0:f2}%", (logisticsExpenses / totalExpenses) * 100);
    }
}
