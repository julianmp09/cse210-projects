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
        Console.WriteLine("Select the type of objective:");
        Console.WriteLine("1. Simple objective");
        Console.WriteLine("2. Eternal objective");
        Console.WriteLine("3. Checklist objective");
        Console.Write("Option: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Objective name: ");
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
                Console.Write("Required times to complete: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: ");
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
        var data = new { Name, Score, Objectives = _objectives };
        string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    public void LoadData(string filePath)
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            var data = JsonSerializer.Deserialize<dynamic>(json);
            Name = data.Name;
            Score = data.Score;
        }
    }
}
