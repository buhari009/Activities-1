using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the userlist");
        int n = Convert.ToInt32(Console.ReadLine());
        HashSet<string> users = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            string userInput = Console.ReadLine().Trim();
            if (!string.IsNullOrEmpty(userInput))
            {
                users.Add(userInput);
            }
        }

        Console.WriteLine($"Total number of unique users {users.Count}");
    }
}
