using System;
using System.Threading;

public abstract class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    protected int Duration { get; set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    // Display the common start message
    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {Name} activity.");
        Console.WriteLine(Description);
        Console.Write("Please enter the duration (in seconds): ");
        Duration = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Get ready...");
        Pause(2);
    }

    // Display the common end message
    public void DisplayEndMessage()
    {
        Console.WriteLine($"Good job! You completed the {Name} activity.");
        Console.WriteLine($"You spent {Duration} seconds on this activity.");
        Pause(2);
    }

    // Pause for a few seconds
    protected void Pause(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            // Simple animation of a countdown
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();  // New line after the animation.
    }

    // Abstract method that each specific activity must implement
    public abstract void ExecuteActivity();
}
