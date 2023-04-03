using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        List<string> halls = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string hallName = Console.ReadLine();
            halls.Add(hallName);
        }
        Console.WriteLine("Enter the hall name to search");
        string searchHall = Console.ReadLine();
        int index = halls.IndexOf(searchHall);

        if (index >= 0)
        {
            Console.WriteLine($"Hall name {searchHall} found at index {index}");
        }
        else
        {
            Console.WriteLine("Hall name not found");
        }
    }
}
