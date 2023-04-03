using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the total number of hall owners");
        int numOwners = int.Parse(Console.ReadLine());

        Dictionary<string, List<string>> hallsByOwner = new Dictionary<string, List<string>>();

        for (int i = 0; i < numOwners; i++)
        {
            Console.WriteLine("Enter owner name {0}", i + 1);
            string owner = Console.ReadLine();

            Console.WriteLine("Enter total number of halls owned by {0}", owner);
            int numHalls = int.Parse(Console.ReadLine());

            List<string> halls = new List<string>();
            Console.WriteLine("Enter list of halls owned by "+owner);

            for (int j = 0; j < numHalls; j++)
            {
                halls.Add(Console.ReadLine());
            }

            hallsByOwner.Add(owner, halls);
        }

        foreach (KeyValuePair<string, List<string>> owner in hallsByOwner)
        {
            Console.WriteLine("Owner Name : {0}", owner.Key);
            Console.WriteLine("Halls Owned :");

            foreach (string hall in owner.Value)
            {
                Console.WriteLine(hall);
            }

            Console.WriteLine();
        }
    }
}
