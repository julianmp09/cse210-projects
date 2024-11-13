using System;

public class DiaryEntry
{
    public string Date { get; set; }
    public string Question { get; set; }
    public string Answer { get; set; }

    // Constructor of the class
    public DiaryEntry(string date, string question, string answer)
    {
        Date = date;
        Question = question;
        Answer = answer;
    }

    // Method to display the entry on the console
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Question: {Question}");
        Console.WriteLine($"Answer: {Answer}");
        Console.WriteLine();
    }
}
