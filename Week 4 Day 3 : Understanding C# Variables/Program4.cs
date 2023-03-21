using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter Flight name :");
        string flightName = Console.ReadLine();
        Console.WriteLine("Enter Ticket No :");
        int ticketNo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Flight Fare :");
        double flightFare = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Travelling Class :");
        char travelClass = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enter Source :");
        string source = Console.ReadLine();
        Console.WriteLine("Enter Destination :");
        string destination = Console.ReadLine();

        Console.WriteLine("Flight Details :");
        Console.WriteLine("Flight Name : " + flightName);
        Console.WriteLine("Ticket No : " + ticketNo);
        Console.WriteLine("Flight Fare : " + flightFare);
        Console.WriteLine("Class : " + travelClass);
        Console.WriteLine("Source : " + source);
        Console.WriteLine("Destination : " + destination);
    }
}
   