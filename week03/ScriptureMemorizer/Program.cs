using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

        string quit = "";


        while ((quit != "quit") && (!scripture.IsCompletelyHidden()))
        {
            Console.Write($"{reference.GetDisplayText()} ");
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            quit = Console.ReadLine();

            Console.Clear();

            scripture.HideRandomWords(2);
        }

        Console.Clear();
        Console.WriteLine("Thanks for playing!!!");
    }
}