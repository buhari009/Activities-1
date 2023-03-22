using System;

class Program {
    static void Main(string[] args) {
        // Read the input bill number
        int billNumber = int.Parse(Console.ReadLine());
        
        
        int digit1 = billNumber / 100;
        int digit2 = (billNumber / 10) % 10;
        int digit3 = billNumber % 10;
        
        if (digit1 == digit3) {
            Console.WriteLine("yes");
        } else {
            Console.WriteLine("no");
        }
    }
}
