using System;

public abstract class Activity
{
    // Private members to encapsulate activity information
    protected DateTime _date;
    protected int _durationInMinutes; // Activity duration in minutes

    // Constructor to initialize common attributes
    public Activity(DateTime date, int durationInMinutes)
    {
        _date = date;
        _durationInMinutes = durationInMinutes;
    }

    // Abstract methods that must be implemented in derived classes
    public abstract double GetDistance();  // Distance in miles or km
    public abstract double GetSpeed();     // Speed in miles per hour or km per hour
    public abstract double GetPace();      // Pace in minutes per mile or km

    // Method to get the summary of the activity
    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_durationInMinutes} min): Distance {GetDistance():F1}, Speed: {GetSpeed():F1}, Pace: {GetPace():F2} min per unit";
    }
}
