using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Start breathing activity");
            Console.WriteLine("     2. Start reflecting activity");
            Console.WriteLine("     3. Start listing activity");
            Console.WriteLine("     4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Clear();

                BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by waiting you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);

                breathing.DisplayStartingMessage();

                Console.Clear();

                Console.WriteLine("Get ready...");
                breathing.ShowSpinner(600);
                breathing.Run();
                breathing.DisplayEndingMessage();

                Console.Clear();
            }
            else if (choice == 2)
            {
                Console.Clear();

                ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of life.", 0);

                reflecting.DisplayStartingMessage();

                Console.Clear();

                Console.WriteLine("Get ready...");
                reflecting.ShowSpinner(600);

                reflecting.Run();
                reflecting.DisplayEndingMessage();

                Console.Clear();
            }
            else if (choice == 3)
            {
                Console.Clear();

                ListingActivity listing = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);

                listing.DisplayStartingMessage();

                Console.Clear();

                Console.WriteLine("Get ready...");
                listing.ShowSpinner(600);

                listing.Run();
                listing.DisplayEndingMessage();

                Console.Clear();
            }
            else if (choice == 4)
            {
                Console.Clear();
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid choice. Please select a valid option from the menu.");
                Console.WriteLine();
            }
        }
        
    }
}