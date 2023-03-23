using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Enter the number :");
    int num = int.Parse(Console.ReadLine());
    int reverse = 0;
    while (num > 0) {
      reverse = reverse * 10 + num % 10;
      num /= 10;
    }
    Console.WriteLine("Reverse of the number is {0}", reverse);
  }
}
