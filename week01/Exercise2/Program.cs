using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Type your grade percentage: ");
        string percentage = Console.ReadLine();

        float number = float.Parse(percentage);
        string letter;
        string sign = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }



        if ((number % 10) >= 7)
        {
            sign = "+";
        }
        else if ((number % 10) < 3)
        {
            sign = "-";
        }



        if ((letter == "A" && sign == "+") || (letter == "F"))
        {
            Console.WriteLine($"Your grade is {letter}");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}{sign}");
        }

        

        if (number >= 70)
        {
            Console.WriteLine("Congrats you pass!");
        }
        else
        {
            Console.WriteLine("Sorry, you need to take this course again, dont give up!");
        }
    }
}