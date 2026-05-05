using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        double gradePercentage = Convert.ToDouble(Console.ReadLine());

        string gradeLetter;
        string message;

        //if statements to determine the grade letter
        if (gradePercentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        //if statements to determine if they pass the class
        if (gradePercentage >= 70)
        {
            message = "Hey!! You pass the class, congratulations!";
        }
        else
        {
            message = "Sorry, but you don't make it, lucky next time";
        }

        Console.WriteLine($"Your grade is {gradeLetter}.\n{message}");

    }
}