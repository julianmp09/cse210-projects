using System;

public class Program
{
    public static void Main(string[] args)
    {
        int userChoice = 0;
        Activity currentActivity = null;

        while (userChoice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();
            if (int.TryParse(input, out userChoice) && userChoice >= 1 && userChoice <= 4)
            {
                switch (userChoice)
                {
                    case 1:
                        currentActivity = new BreathingActivity();
                        break;
                    case 2:
                        currentActivity = new ReflectionActivity();
                        break;
                    case 3:
                        currentActivity = new ListingActivity();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                }

                if (currentActivity != null)
                {
                    currentActivity.ExecuteActivity();
                    currentActivity = null;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                Console.ReadLine();
            }
        }
    }
}
