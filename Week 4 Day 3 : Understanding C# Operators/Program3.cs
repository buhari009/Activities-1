using System;
class Program{
    public static void Main(string [] args)
    {
        float am;
        int n=0;
        char c;
        bool flag= true;
       
        Console.WriteLine("Enter the amount you are entering the game with:");
        am = float.Parse(Console.ReadLine());
        if(am<1000)
            {   
                Console.WriteLine("You cannot enter the game with this money");
                flag = false;
            }
        if(flag == true)
        {
        do{
            while(true)
            {
            Console.WriteLine("Value of dice");
            n= int.Parse(Console.ReadLine());
            if(n<=0 || n>6)
            {   
                Console.WriteLine("Invalid value");
                Console.WriteLine("Please enter a valid value");
            }
            else{
                break;
            }
            }
            if(n==1)
            {
            am = am/2; 
            break;
            }
            else{
                am += 100*n;
            }
            Console.WriteLine("Do you continue[y or n]?");
            c = char.Parse(Console.ReadLine());
        }while(c=='y');

         Console.WriteLine("Amount received while leaving the game "+am);
        }

    }

}
