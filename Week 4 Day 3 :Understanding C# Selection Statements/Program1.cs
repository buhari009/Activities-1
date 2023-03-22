using System;

class Program {
    public static void Main(String[] args) {
        //Fill your code here
        int num=int.Parse(Console.ReadLine());

        if(num%2==0)
        {
            Console.WriteLine(num+" is an even number");
        }
        else{
            Console.WriteLine(num+" is an odd number");

        }
    }
}