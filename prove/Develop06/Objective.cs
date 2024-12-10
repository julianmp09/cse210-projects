public abstract class Objective
{
    public string Name { get; protected set; }
    public int Points { get; protected set; }
    public abstract string GetStatus();
    public abstract int RegisterProgress();
}
