using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        User user = new User("Player");
        string filePath = "userData.json";

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Eternal Quest ===");
            Console.WriteLine("1. Create objective");
            Console.WriteLine("2. Register progress");
            Console.WriteLine("3. Display objectives");
            Console.WriteLine("4. Show score and level");
            Console.WriteLine("5. Save data");
            Console.WriteLine("6. Load data");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    user.CreateObjective();
                    break;
                case "2":
                    user.RegisterProgress();
                    break;
                case "3":
                    user.DisplayObjectives();
                    break;
                case "4":
                    Console.WriteLine($"Score: {user.Score}, Level: {user.Level}");
                    break;
                case "5":
                    user.SaveData(filePath);
                    Console.WriteLine("Data saved.");
                    break;
                case "6":
                    user.LoadData(filePath);
                    Console.WriteLine("Data loaded.");
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
