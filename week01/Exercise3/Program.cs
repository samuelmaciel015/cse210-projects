using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");


        string again = "";

        while ((again != "NO") || (again != "no") || (again != "No") || (again != "nO"))
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            int guess;
            int counter = 0;

            do
            {
                Console.Write("What is your guess? ");
                string guessNumber = Console.ReadLine();
                guess = int.Parse(guessNumber);
                counter += 1;

                if (number > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (number < guess)
                {
                    Console.WriteLine("Lower");
                }
            } while (number != guess);

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You try {counter} times.");

            Console.WriteLine("Do you want to play again (YES/NO)? ");
            again = Console.ReadLine();
        }

        Console.WriteLine("Thank you for playing!");

    }
}