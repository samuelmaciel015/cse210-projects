using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        PromptGenerator generatePrompt = new PromptGenerator();
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        do
        {
            Console.Write("Please select one of the following choices:\n1.   Write\n2.   Display\n3.   Load\n4.   Save\n5.   Quit\nWhat would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = generatePrompt.GetRandomPrompt();

                Console.WriteLine(entry._promptText);
                Console.Write("> ");
                entry._entryText = Console.ReadLine();

                journal.AddEntry(entry);
            }
            else if(choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                journal.LoadFromFile();
            }
            else if (choice == "4")
            {
                journal.SaveToFile();
            }
            else if (choice != "5")
            {
                Console.WriteLine("Please, select a valid option!");
            }

        } while (choice != "5");
        
    }
}