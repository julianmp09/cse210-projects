using System;

public class Swimming : Activity
{
    private int _laps; // Number of laps swum

    public Swimming(DateTime date, int durationInMinutes, int laps)
        : base(date, durationInMinutes)
    {
        _laps = laps;
    }

    // Implementing the distance calculation in miles (assuming 50 meters per lap)
    public override double GetDistance()
    {
        // Convert 50 meters per lap to miles
        return (_laps * 50 / 1000) * 0.62;
    }

    // Implementing speed in miles per hour
    public override double GetSpeed()
    {
        double distanceInMiles = GetDistance();
        return (distanceInMiles / _durationInMinutes) * 60;
    }

    // Implementing pace calculation in minutes per lap
    public override double GetPace()
    {
        double distanceInMiles = GetDistance();
        return _durationInMinutes / distanceInMiles;
    }
}
