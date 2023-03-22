using System;

class Program {
  public static void Main (string[] args) {
    int num1 = int.Parse(Console.ReadLine());;
    int num2 = int.Parse(Console.ReadLine());
    int num3 = int.Parse(Console.ReadLine());

    int max = num1;

    if (num2 > max) {
      max = num2;
    }

    if (num3 > max) {
      max = num3;
    }
    Console.WriteLine($"{max} is the maximum number");
  }
}
