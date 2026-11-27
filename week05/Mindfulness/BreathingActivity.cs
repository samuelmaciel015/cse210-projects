public class BreathingActivity : Activity
{
    //constructor
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    
    //method
    public void Run()
    {

        int i = 0;

        if (_duration % 10 == 0)
        {
            while (i != (_duration / 10))
            {
                Console.WriteLine();
                Console.Write("Breathe in...");
                ShowCountDown(4);
                Console.WriteLine();

                Console.Write("Breathe out...");
                ShowCountDown(6);

                Console.WriteLine();

                i += 1;
            }
        }
        else
        {
            while (i != ((_duration / 10) + 1))
            {
                Console.WriteLine();
                Console.Write("Breathe in...");
                ShowCountDown(4);
                Console.WriteLine();

                Console.Write("Breathe out...");
                ShowCountDown(6);

                Console.WriteLine();

                i += 1;
            }
        }
    }
}