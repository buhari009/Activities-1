using System;

public class Program {
  public static void Main() {
    int num = int.Parse(Console.ReadLine());
    bool isPrime = true;
    if (num == 1) {
      isPrime = false;
    }
    for (int i = 2; i <= Math.Sqrt(num); i++) {
      if (num % i == 0) {
        isPrime = false;
        break;
      }
    }
    if (isPrime) {
      Console.WriteLine("Prime");
    } else {
      Console.WriteLine("Not prime");
    }
  }
}
