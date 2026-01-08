using System;

class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string strNumber = Console.ReadLine();
            int number = int.Parse(strNumber);
            return number;
        }

        int SquareNumber (int number)
        {
            int squared = number * number;
            return squared;
        }

        void DisplayResult (string name, int squared)
        {
            Console.WriteLine($"{name}, the square of your number is {squared}");
        }

        DisplayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
    }
}