using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter total number of stalls");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            string[] details = Console.ReadLine().Split(',');
            Stall stall = new Stall(details[0], details[1], details[2]);
            Stall.StallList.Add(stall);
        }

        Console.WriteLine("Updated Stall List");

        // Use a for loop to iterate through the list of stalls
        for (int i = 0; i < Stall.StallList.Count; i++)
        {
            Stall stall = Stall.StallList[i];

            // Check if the name of the stall starts with "test"
            if (stall.Name.ToLower().StartsWith("test"))
            {
                // Remove the stall from the list
                Stall.StallList.RemoveAt(i);

                // Decrement the counter to avoid skipping an item in the list
                i--;
            }
            else
            {
                // Print the stall details
                Console.WriteLine(stall);
            }
        }
    }
}
