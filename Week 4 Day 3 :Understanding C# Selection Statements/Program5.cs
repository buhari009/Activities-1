using System;

class Program{
  public static void Main (string[] args) {
    
    Console.WriteLine("Richter Magnitude:");
    float magnitude = float.Parse(Console.ReadLine());

    
    string intensity = "";
    if (magnitude <= 2.4) {
      intensity = "Micro";
    }
    else if (magnitude <= 5.4) {
      intensity = "Light";
    }
    else if (magnitude <= 6.0) {
      intensity = "Moderate";
    }
    else if (magnitude <= 6.9) {
      intensity = "Strong";
    }
    else if (magnitude <= 7.9) {
      intensity = "Major";
    }
    else {
      intensity = "Great";
    }

    
    Console.WriteLine(intensity);
  }
}
