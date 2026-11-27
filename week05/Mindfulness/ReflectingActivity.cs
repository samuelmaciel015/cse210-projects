public class ReflectingActivity : Activity
{
    //attributes
    private List<string> _prompts;
    private List<string> _questions;

    //constructor
    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        
        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    //methods
    public void Run()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        int i = 0;
        while (i != (_duration / 10))
        {
            DisplayQuestion();
            ShowSpinner(600);
            Thread.Sleep((_duration / (_duration / 10)) * 1000);
            Console.WriteLine();
            i += 1;
        }
    }
    public string GetRandomPrompt()
    {
        Random number = new Random();
        int index = number.Next(_prompts.Count);

        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        Random number = new Random();
        int index = number.Next(_questions.Count);

        return _questions[index];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }
    public void DisplayQuestion()
    {
        Console.Write($"> {GetRandomQuestion()} ");
    }
}