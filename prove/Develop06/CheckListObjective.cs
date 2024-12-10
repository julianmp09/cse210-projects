public class ChecklistObjective : Objective
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistObjective(string name, int points, int targetCount, int bonusPoints)
    {
        Name = name;
        Points = points;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _timesCompleted = 0;
    }

    public override string GetStatus()
    {
        return $"[ ] {Name} ({_timesCompleted}/{_targetCount})";
    }

    public override int RegisterProgress()
    {
        _timesCompleted++;
        if (_timesCompleted == _targetCount)
        {
            return Points + _bonusPoints;
        }
        return Points;
    }
}
