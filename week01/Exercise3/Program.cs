using System;

class Program
{
    static void Main(string[] args)
    {
        Random generateRandomNumber = new Random();

        int magicNumber = generateRandomNumber.Next(1, 101);

        int guessNumber;

        do
        {
            Console.Write("What do you think it is the magic number? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
        } while (magicNumber != guessNumber);

        Console.WriteLine("You guessed it!");
    }
}