//I improve the process of saving and loading to save as a csv file.
using System;
using System.Drawing;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        string choice;
        Journal journal = new Journal();
        
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();


        do
        {
            Console.WriteLine("Please select one of th following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                PromptGenerator prompt = new PromptGenerator();
                string promptCreated = prompt.GetRandomPrompt();
                Console.WriteLine(promptCreated);
                Console.Write("> ");
                string data = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = dateText;
                entry._entryText = data;
                entry._promptText = promptCreated;
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }

        } while (choice != "5");
    }
}