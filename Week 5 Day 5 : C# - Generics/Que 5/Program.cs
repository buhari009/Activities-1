using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter total number of halls");
        int n = int.Parse(Console.ReadLine());

        Hall[] halls = new Hall[n];
        Console.WriteLine("Enter Hall Details");

        for (int i = 0; i < n; i++)
        {
            string[] details = Console.ReadLine().Split(',');
            string name = details[0];
            long mobileNumber = long.Parse(details[1]);
            string ownerName = details[2];
            double costPerDay = double.Parse(details[3]);
            halls[i] = new Hall(name, mobileNumber, ownerName, costPerDay);
        }

        Array.Sort(halls);

        Console.WriteLine("Hall Name            MobileNumber    OwnerName       CostPerDay");

        foreach (Hall hall in halls)
        {
            Console.WriteLine(hall);
        }
    }
}
