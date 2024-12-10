public class SimpleObjective : Objective
{
    public bool IsCompleted { get; private set; }

    public SimpleObjective(string name, int points)
    {
        Name = name;
        Points = points;
        IsCompleted = false;
    }

    public override string GetStatus()
    {
        return IsCompleted ? "[X] " + Name : "[ ] " + Name;
    }

    public override int RegisterProgress()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            return Points;
        }
        return 0;
    }
}
