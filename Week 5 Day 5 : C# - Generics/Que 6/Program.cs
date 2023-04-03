using System;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Enter total number of users");
        int n = int.Parse(Console.ReadLine());

        User[] users = new User[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter User Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter User Address");
            Console.WriteLine("Enter Address line 1");
            string add1 = Console.ReadLine();

            Console.WriteLine("Enter Address line 2");
            string add2 = Console.ReadLine();

            Console.WriteLine("Enter Pincode");
            long pincode = long.Parse(Console.ReadLine());

            users[i] = new User(name, add1, add2, pincode);
        }

        Array.Sort(users);

        foreach (User user in users)
        {
            Console.WriteLine(user.ToString());
        }
    }
}
