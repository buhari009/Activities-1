using System;

public class GenericClass
{
    public static void Print<T>(T element)
    {
        Console.WriteLine(element);
    }
}
