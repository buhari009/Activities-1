using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter current year :");
        int currentYear = Convert.ToInt32(Console.ReadLine());
       int csharpYear = 2006;
        Console.WriteLine("C# was created in the year " + csharpYear + ". I am reading C# in the year " + currentYear);
    }
}
   