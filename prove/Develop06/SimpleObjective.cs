public class SimpleObjective : Objective
{
    public bool IsCompleted { get; private set; }

    public SimpleObjective(string name, int points, bool isCompleted = false)
    {
        Name = name;
        Points = points;
        IsCompleted = isCompleted;
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

    public override string Serialize()
    {
        return $"Simple,{Name},{Points},{IsCompleted}";
    }
}
