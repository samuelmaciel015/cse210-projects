using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string choice;
        Entry entry = new Entry();
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Jorunal Program!");

        do
        {
            Console.WriteLine("\nPlease select one of the following choices:\n1.Write\n2.Display\n3.Load\n4.Save\n5.Quit");

            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {                
                //generate prompt with the random number
                PromptGenerator prompt = new PromptGenerator();
                string newPrompt = prompt.GetRandomPrompt();
                Console.WriteLine(newPrompt);

                //store the answer
                Console.Write("> ");
                string answer = Console.ReadLine();

                //add to the entry
                entry._promptText = newPrompt;
                entry._entryText = answer;
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename?");
                string name = Console.ReadLine();

                journal.LoadFromFile(name);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                string name = Console.ReadLine();

                journal.SaveToFile(name);
            }
            else
            {
                Console.WriteLine("That's no an option, try again.");
            }
        } while (choice != "5");

    }
}