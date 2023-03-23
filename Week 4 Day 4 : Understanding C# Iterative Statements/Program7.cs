using System;

class Program {
    static void Main(string[] args) {
        int number = int.Parse(Console.ReadLine());

        if (number< 10) {
            Console.WriteLine("Invalid Input");
        } else {
            int lastDigit = number % 10;
            int firstDigit = number;
            while (firstDigit >= 10) {
                firstDigit /= 10;
            }
            int absoluteDifference = Math.Abs(firstDigit - lastDigit);

            Console.WriteLine(absoluteDifference);
        }
    }
}
