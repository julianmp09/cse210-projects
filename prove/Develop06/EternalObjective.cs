public class EternalObjective : Objective
{
    public EternalObjective(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public override string GetStatus()
    {
        return "[∞] " + Name;
    }

    public override int RegisterProgress()
    {
        return Points;
    }

    public override string Serialize()
    {
        return $"Eternal,{Name},{Points}";
    }
}
