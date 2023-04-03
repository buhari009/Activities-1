using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList hallList = new ArrayList();

        do
        {
            Console.WriteLine("Enter the hall name");
            string hallName = Console.ReadLine();

            if (!hallList.Contains(hallName))
            {
                hallList.Add(hallName);
            }

            Console.WriteLine("Do you want to add hall?(Yes/No)");
        } while (Console.ReadLine().Equals("Yes", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Unique halls");

        IEnumerator hallEnumerator = hallList.GetEnumerator();

        while (hallEnumerator.MoveNext())
        {
            Console.WriteLine(hallEnumerator.Current);
        }
    }
}
