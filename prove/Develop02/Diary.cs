using System;
using System.Collections.Generic;
using System.IO;

public class Diary
{
    private List<DiaryEntry> entries;

    // Constructor of the class
    public Diary()
    {
        entries = new List<DiaryEntry>();
    }

    // Add a new entry to the diary
    public void AddEntry(string date, string question, string answer)
    {
        var newEntry = new DiaryEntry(date, question, answer);
        entries.Add(newEntry);
    }

    // Display all diary entries
    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("There are no entries in the diary.");
        }
        else
        {
            foreach (var entry in entries)
            {
                entry.DisplayEntry();
            }
        }
    }

    // Save the diary to a file
    public void SaveDiary(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.Question}|{entry.Answer}");
                }
            }
            Console.WriteLine("Diary saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving the file: " + ex.Message);
        }
    }

    // Load the diary from a file
    public void LoadDiary(string fileName)
    {
        try
        {
            if (File.Exists(fileName))
            {
                entries.Clear();
                string[] lines = File.ReadAllLines(fileName);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        var date = parts[0];
                        var question = parts[1];
                        var answer = parts[2];
                        AddEntry(date, question, answer);
                    }
                }
                Console.WriteLine("Diary loaded successfully.");
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading the file: " + ex.Message);
        }
    }
}
