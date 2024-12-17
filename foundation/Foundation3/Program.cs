using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of activities
        List<Activity> activities = new List<Activity>();

        // Create objects of each activity type and add them to the list
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));    // 3 miles in 30 minutes
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 30, 15.0));   // 15 mph for 30 minutes
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 40));   // 40 laps in 30 minutes

        // Iterate over the list and display the summary of each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
