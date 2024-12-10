public class User
{
    private List<Objective> _objectives = new();
    public string Name { get; private set; }
    public int Score { get; private set; }
    public int Level => Score / 1000;

    public User(string name)
    {
        Name = name;
        Score = 0;
    }

    public void CreateObjective()
    {
        Console.WriteLine("Select the type of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal: ");
        string name = Console.ReadLine();

        Console.Write("Points per progress: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                _objectives.Add(new SimpleObjective(name, points));
                break;
            case 2:
                _objectives.Add(new EternalObjective(name, points));
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("What is the amount of points associated with this goal? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                _objectives.Add(new ChecklistObjective(name, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

    public void RegisterProgress()
    {
        DisplayObjectives();
        Console.Write("Select an objective (index): ");
        int index = int.Parse(Console.ReadLine());
        if (index >= 0 && index < _objectives.Count)
        {
            Score += _objectives[index].RegisterProgress();
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    public void DisplayObjectives()
    {
        for (int i = 0; i < _objectives.Count; i++)
        {
            Console.WriteLine($"{i}. {_objectives[i].GetStatus()}");
        }
    }

    public void SaveData(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine($"{Name},{Score}");
            foreach (var objective in _objectives)
            {
                writer.WriteLine(objective.Serialize());
            }
        }
    }

    public void LoadData(string filePath)
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            string[] userInfo = lines[0].Split(',');
            Name = userInfo[0];
            Score = int.Parse(userInfo[1]);
            _objectives.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                switch (parts[0])
                {
                    case "Simple":
                        _objectives.Add(new SimpleObjective(parts[1], int.Parse(parts[2]), bool.Parse(parts[3])));
                        break;
                    case "Eternal":
                        _objectives.Add(new EternalObjective(parts[1], int.Parse(parts[2])));
                        break;
                    case "Checklist":
                        _objectives.Add(new ChecklistObjective(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
