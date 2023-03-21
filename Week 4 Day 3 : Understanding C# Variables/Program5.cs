using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter name :");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Roll No :");
        int rollNo = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Subject :");
        string subject = Console.ReadLine();

        Console.WriteLine("Enter Marks :");
        double marks = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Grade :");
        char grade = char.Parse(Console.ReadLine());

        Console.WriteLine($"{name} Details :");
        Console.WriteLine($"Roll No : {rollNo}");
        Console.WriteLine($"Subject : {subject}");
        Console.WriteLine($"Marks : {marks:F1}");
        Console.WriteLine($"Grades : {grade}");
    }
}
