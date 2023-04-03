using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter total number of users");
        int n = int.Parse(Console.ReadLine());

        List<User> userList = new List<User>();

        for (int i = 0; i < n; i++)
        {
            string[] userDetails = Console.ReadLine().Split(',');

            User user = new User(userDetails[0], userDetails[1], userDetails[2]);

            userList.Add(user);
        }

        MyComparer myComparer = new MyComparer();
        userList.Sort(myComparer);

        Console.WriteLine("Enter UserName to search");
        string username = Console.ReadLine();

        int index = userList.BinarySearch(new User(username, "", ""), myComparer);

        if (index >= 0)
        {
            Console.WriteLine("User Found ! User Details are");
            Console.WriteLine(userList[index].ToString());
        }
        else
        {
            Console.WriteLine("User Not Found");
        }
    }
}
