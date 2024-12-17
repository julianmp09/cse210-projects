using System;

public class Running : Activity
{
    private double _distanceInMiles; // Distance in miles

    public Running(DateTime date, int durationInMinutes, double distanceInMiles)
        : base(date, durationInMinutes)
    {
        _distanceInMiles = distanceInMiles;
    }

    // Implementing the distance calculation
    public override double GetDistance()
    {
        return _distanceInMiles;
    }

    // Implementing speed calculation in miles per hour
    public override double GetSpeed()
    {
        return (_distanceInMiles / _durationInMinutes) * 60;
    }

    // Implementing pace calculation in minutes per mile
    public override double GetPace()
    {
        return _durationInMinutes / _distanceInMiles;
    }
}
