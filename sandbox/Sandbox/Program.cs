using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!!!");
        Console.WriteLine("This is in C#.");

        Console.Write("Whats your favorite color? ");
        string color = Console.ReadLine();
        Console.WriteLine($"Your color is {color}");

    }
}