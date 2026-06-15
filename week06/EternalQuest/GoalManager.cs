public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void Start()
    {
        string choice = "";

        while (choice != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("	1. Create New Goal");
            Console.WriteLine("	2. List Goals");
            Console.WriteLine("	3. Save Goals");
            Console.WriteLine("	4. Load Goals");
            Console.WriteLine("	5. Record Goals");
            Console.WriteLine("	6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                ListGoalNames();
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points");
        Console.WriteLine();
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("	1. Simple Goal");
        Console.WriteLine("	2. Eternal Goal");
        Console.WriteLine("	3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
    }
    public void ListGoalDetails()
    {
        Console.WriteLine($"The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            if (_goals[i].GetType().Name == "SimpleGoal")
            {
                if (_goals[i].IsComplete() == true)
                {
                    Console.WriteLine($"{i + 1}. [X] {_goals[i].GetDetailsString()}");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. [ ] {_goals[i].GetDetailsString()}");
                }
            }
            else if (_goals[i].GetType().Name == "ChecklistGoal")
            {
                if (_goals[i].IsComplete() == true)
                {
                    Console.WriteLine($"{i + 1}. [X] {_goals[i].GetDetailsString()}");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. [ ] {_goals[i].GetDetailsString()}");
                }
            }
            else
            {
                Console.WriteLine($"{i + 1}. [ ] {_goals[i].GetDetailsString()}");
            }
        }
    }
    public void CreateGoal()
    {
        string goal = Console.ReadLine();

        if (goal == "1")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string point = Console.ReadLine();

            SimpleGoal simpleGoal = new SimpleGoal(name, description, point);
            _goals.Add(simpleGoal);
        }
        else if (goal == "2")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string point = Console.ReadLine();

            EternalGoal eternalGoal = new EternalGoal(name, description, point);
            _goals.Add(eternalGoal);
        }
        else if (goal == "3")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string point = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, point, target, bonus);
            _goals.Add(checklistGoal);
        }
    }
    public void RecordEvent()
    {
        Console.Write("Which goal did you accomplish? ");
        int goal = int.Parse(Console.ReadLine());

        int index = goal - 1;

        if (_goals[index].GetType().Name == "SimpleGoal")
        {
            _goals[index].RecordEvent();
        }
        else if (_goals[index].GetType().Name == "ChecklistGoal")
        {
            _goals[index].RecordEvent();
        }

        Console.WriteLine($"Congratulations! You have earned {_goals[index].GetPoints()} points");

        _score += _goals[index].GetPoints();

        Console.WriteLine($"You now have {_score}");
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        foreach (string line in lines)
        {
            string[] parts = line.Split(':', ',');

            string className = parts[0];

            if (className == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], parts[3]);
                _goals.Add(simpleGoal);
            }
            else if (className == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], parts[3]);
                _goals.Add(eternalGoal);
            }
            else if (className == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[5]), int.Parse(parts[4]));
                _goals.Add(checklistGoal);
            }
        }
    }
}