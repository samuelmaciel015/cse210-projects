using System;

class Program
{
    static void Main(string[] args)
    {
        string again;
        do
        {
            Console.WriteLine("GUESS THE MAGIC NUMBER");

            //generate magic number
            Random numberGenerator = new Random();
            int number = numberGenerator.Next(1, 101);

            //guess variable
            int guess;
            int guessesNumber = 0;

            do
            {
                Console.Write("What is your guess? ");
                string strGuess = Console.ReadLine();
                guess = int.Parse(strGuess);

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                    guessesNumber++;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                    guessesNumber++;
                }
            } while (guess != number);

            Console.WriteLine($"Before {guessesNumber} guesses you finally guessed it! Congrats!!");
            Console.Write("Do you want to play again?(yes or no) ");
            again = Console.ReadLine();
            Console.Clear();

        } while (again == "yes");

        Console.WriteLine("Thank you for playing with us!!");
        


    }
}