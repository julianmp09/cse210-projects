using System;

public class Cycling : Activity
{
    private double _speedInMph; // Speed in miles per hour

    public Cycling(DateTime date, int durationInMinutes, double speedInMph)
        : base(date, durationInMinutes)
    {
        _speedInMph = speedInMph;
    }

    // Implementing the distance calculation in miles
    public override double GetDistance()
    {
        return (_speedInMph * _durationInMinutes) / 60;
    }

    // Implementing speed in miles per hour
    public override double GetSpeed()
    {
        return _speedInMph;
    }

    // Implementing pace calculation in minutes per mile
    public override double GetPace()
    {
        return 60 / _speedInMph;
    }
}
