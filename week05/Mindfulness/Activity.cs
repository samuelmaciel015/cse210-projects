public class Activity
{
    //attributes
    public string _name;
    public string _description;
    public int _duration;

    //constructor
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    //methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(600);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(600);
    }
    public void ShowSpinner(int seconds)
    {
        Console.Write("\\");

        Thread.Sleep(seconds);
        Console.Write("\b \b");

        Console.Write("/");

        Thread.Sleep(seconds);
        Console.Write("\b \b");

        Console.Write("-");

        Thread.Sleep(seconds);
        Console.Write("\b \b");

        Console.Write("\\");
        

        Thread.Sleep(seconds);
        Console.Write("\b \b");

        Console.Write("/");

        Thread.Sleep(seconds);
        Console.Write("\b \b");

        Console.Write("-");
        Console.Write("\b \b");
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}