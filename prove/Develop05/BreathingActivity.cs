using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity helps you relax by breathing deeply. Clear your mind and focus on your breathing.")
    {
    }

    public override void ExecuteActivity()
    {
        DisplayStartMessage();

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Inhale...");
            Pause(4);  // Pause for 4 seconds during inhaling

            Console.WriteLine("Exhale...");
            Pause(4);  // Pause for 4 seconds during exhaling
        }

        DisplayEndMessage();
    }
}
