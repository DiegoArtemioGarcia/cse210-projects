public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        string option;
        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("0. Exit");
            option = Console.ReadLine();

            switch (option)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": RecordEvent(); break;
                case "4": DisplayPlayerInfo(); break;
                case "5": SaveGoals(); break;
                case "6": LoadGoals(); break;
            }
        } while (option != "0");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current score: {_score}");
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()} - Completed: {_goals[i].IsComplete()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter the goal type (1=Simple, 2=Eternal, 3=Checklist):");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal;
        switch (type)
        {
            case "1":
                goal = new SimpleGoal(name, desc, points);
                break;
            case "2":
                goal = new EternalGoal(name, desc, points);
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, desc, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid type.");
                return;
        }

        _goals.Add(goal);
    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you complete? ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= _goals.Count)
        {
            index--; // ajustar a índice 0-based
            int pointsEarned = _goals[index].RecordEvent();
            _score += pointsEarned;
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    public void SaveGoals()
    {
        File.WriteAllText("goals.txt", _score + "\n" + string.Join("\n", _goals.Select(g => g.GetStringRepresentation())));
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        try
        {
            if (!File.Exists("goals.txt")) return;
            string[] lines = File.ReadAllLines("goals.txt");
            if (lines.Length == 0) return;

            _score = int.Parse(lines[0]);
            _goals.Clear();
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                if (parts.Length < 3) continue;

                try
                {
                    switch (parts[0])
                    {
                        case "SimpleGoal" when parts.Length >= 4:
                            var simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                            if (parts.Length > 4 && bool.Parse(parts[4]))
                            {
                                simpleGoal.RecordEvent();
                            }
                            _goals.Add(simpleGoal);
                            break;

                        case "EternalGoal" when parts.Length >= 4:
                            _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                            break;

                        case "ChecklistGoal" when parts.Length >= 7:
                            var cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                                                       int.Parse(parts[5]), int.Parse(parts[4]));
                            cg.SetAmountCompleted(int.Parse(parts[6]));
                            _goals.Add(cg);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading goal at line {i + 1}: {ex.Message}");
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals file: {ex.Message}");
        }
    }
}
