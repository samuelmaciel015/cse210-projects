using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string strPercentage = Console.ReadLine();

        int percentage = int.Parse(strPercentage);
        string letter;
        string sign = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (percentage % 10 >= 7 && (letter != "A" && letter != "F"))
        {
            sign = "+";
        }
        else if (percentage % 10 < 3 && (letter != "F"))
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You pass!");
        }
        else
        {
            Console.WriteLine("Sorry, you didnt pass, lucky next time!");
        }
    }
}