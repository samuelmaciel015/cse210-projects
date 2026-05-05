using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guessNumber;

        do
        {
            Console.Write("What is the magic number? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        } while (guessNumber != magicNumber);

Console.WriteLine("You guessed it!");
    }
}