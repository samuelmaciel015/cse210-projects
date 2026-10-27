using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());

        char letter;

        if (gradePercentage >= 90)
        {
            letter = 'A';
        }
        else if (gradePercentage >= 80)
        {
            letter = 'B';
        }
        else if (gradePercentage >= 70)
        {
            letter = 'C';
        }
        else if (gradePercentage >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        //SEE IF PASS THE COURSE
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You pass!");
        }
        else
        {
            Console.WriteLine("You don't pass, see you next time!");
        }

        Console.WriteLine($"Your grade is {letter}");
    }
}