using System;

class Program {
    public static void Main(String[] args) {
        //Fill your code here
        int num=int.Parse(Console.ReadLine());

        if(num%7==0 && num%3==0){
            Console.WriteLine(num+" is divisible by both 7 and 3");
    }
        else{
            Console.WriteLine(num+" is not divisible by both 7 and 3");

        }

    }
}