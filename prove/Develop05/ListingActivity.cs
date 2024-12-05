using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are the people you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "When did you feel the Spirit this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity helps you reflect on the good things in your life by listing as many things as you can in a specific area.")
    {
    }

    public override void ExecuteActivity()
    {
        DisplayStartMessage();

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Pause(2);

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Think about the prompt and start listing items.");
            Console.WriteLine("Press Enter to add an item or type 'done' to finish.");
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "done")
                    break;

                itemCount++;
            }

            Pause(5);  // Pause for 5 seconds to reflect
        }

        Console.WriteLine($"You listed {itemCount} items.");
        DisplayEndMessage();
    }
}
