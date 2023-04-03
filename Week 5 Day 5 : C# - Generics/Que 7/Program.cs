using System;

namespace IComparerSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total number of users");
            int totalUsers = int.Parse(Console.ReadLine());

            User[] users = new User[totalUsers];

            Console.WriteLine("Enter User Details");

            for (int i = 0; i < totalUsers; i++)
            {
                string[] input = Console.ReadLine().Split(',');
                users[i] = new User(input[0], input[1], input[2]);
            }

            Console.WriteLine("Sort By 1]Name 2]Email");
            int sortParameter = int.Parse(Console.ReadLine());

            if (sortParameter == 1)
            {
                Array.Sort(users, new NameComparator());
            }
            else if (sortParameter == 2)
            {
                Array.Sort(users, new EmailComparator());
            }

            foreach (User user in users)
            {
                Console.WriteLine(user);
            }
        }
    }
}
