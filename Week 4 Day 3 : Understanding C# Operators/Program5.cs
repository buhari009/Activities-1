using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Has the player represented for India[y or n]?");
        char playedForIndia = char.Parse(Console.ReadLine());

        double amountReceived = 0;

        if (playedForIndia == 'y')
        {
            Console.WriteLine("Enter the number of Test matches he has played");
            int testMatches = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of ODI matches he has played");
            int odiMatches = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of man of the matches he has won");
            int momAwards = int.Parse(Console.ReadLine());

            if (testMatches > 10 && odiMatches > 100)
            {
                amountReceived = 50000;
            }
            else if (testMatches > 10)
            {
                amountReceived = 25000;
            }
            else if (odiMatches > 100)
            {
                amountReceived = 15000;
            }
            else
            {
                amountReceived = 10000;
            }

            amountReceived += momAwards * 0.25 * amountReceived;
        }
        else
        {
            Console.WriteLine("Has he played IPL[y or n]?");
            char playedIPL = char.Parse(Console.ReadLine());

            if (playedIPL == 'y')
            {
                amountReceived = 8000;
            }
            else
            {
                amountReceived = 7000;
            }
        }

        Console.WriteLine("Amount received as pension: Rs.{0:F1}" , amountReceived);
    }
}
   