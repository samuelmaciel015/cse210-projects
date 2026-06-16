using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        List<Activity> activities = new List<Activity>();

        while (choice != "3")
        {
            Console.WriteLine();
            Console.WriteLine("	1. Create an exercise");
            Console.WriteLine("	2. List the exercises");
            Console.WriteLine("	3. Quit");
            Console.Write("Select the exercise you want to track: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine();
                Console.WriteLine("	1. Running");
                Console.WriteLine("	2. Cycling");
                Console.WriteLine("	3. Swimming");
                Console.Write("Select the exercise you want to track: ");
                string exercise = Console.ReadLine();

                if (exercise == "1")
                {
                    Console.Write("When do you ran(dd/mm/yyyy)? ");
                    string date = Console.ReadLine();
                    Console.Write("How long in minutes? ");
                    int minutes = int.Parse(Console.ReadLine());
                    Console.Write("What was the distance? ");
                    float distance = float.Parse(Console.ReadLine());

                    RunningActivity running = new RunningActivity(date, minutes, distance);
                    activities.Add(running);
                }
                else if (exercise == "2")
                {
                    Console.Write("When did you last ride your bike(dd/mm/yyyy)? ");
                    string date = Console.ReadLine();
                    Console.Write("How long in minutes? ");
                    int minutes = int.Parse(Console.ReadLine());
                    Console.Write("What was the speed? ");
                    float speed = float.Parse(Console.ReadLine());

                    CyclingActivity cycling = new CyclingActivity(date, minutes, speed);
                    activities.Add(cycling);
                }
                else if (exercise == "3")
                {
                    Console.Write("When did you last swim(dd/mm/yyyy)? ");
                    string date = Console.ReadLine();
                    Console.Write("How long in minutes? ");
                    int minutes = int.Parse(Console.ReadLine());
                    Console.Write("How many laps? ");
                    int laps = int.Parse(Console.ReadLine());

                    SwimmingActivity swimming = new SwimmingActivity(date, minutes, laps);
                    activities.Add(swimming);
                }
            }
            else if (choice == "2")
            {
                foreach (Activity activity in activities)
                {
                    Console.Write(activity.GetSummary());
                    Console.WriteLine();
                }
            }
            else if (choice == "3")
            {
                Console.Clear();
                Console.WriteLine("Thank you!");
            }
            else
            {
                Console.WriteLine("This is not a valid number. Try again");
                Console.WriteLine();
            }
        }
    }
}