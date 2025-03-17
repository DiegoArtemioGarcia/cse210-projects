using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();  // List to store journal entries

    // List of pre-defined prompts (randomly chosen for each new entry)
    private static readonly List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the Lord's hand in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had to accomplish one thing today, what would it be?"
    };

    // Adds a new journal entry with a random prompt
    public void AddEntry()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)]; // Selects a random prompt

        Console.WriteLine($"\n{prompt}");  // Displays the prompt
        Console.Write("Your response: ");
        string response = Console.ReadLine();  // Gets the user's response

        entries.Add(new Entry(prompt, response));  // Creates and adds the entry
        Console.WriteLine("Entry saved successfully.\n");
    }

    // Displays all journal entries
    public void DisplayEntries()
    {
        if (entries.Count == 0)  // Check if the journal is empty
        {
            Console.WriteLine("\nThe journal is empty.\n");
            return;
        }

        Console.WriteLine("\n--- Journal Entries ---");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
        Console.WriteLine();
    }

    // Saves all journal entries to a file
    public void SaveToFile()
    {
        Console.Write("Enter the filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))  // Opens file for writing
        {
            foreach (var entry in entries)
            {
                // Writing each entry as: Date | Prompt | Response
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved successfully.\n");
    }

    // Loads journal entries from a file
    public void LoadFromFile()
    {
        Console.Write("Enter the filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))  // Checks if the file exists
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        entries.Clear();  // Clears existing journal entries
        string[] lines = File.ReadAllLines(filename);  // Reads all lines from the file

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');  // Splits each line by '|'

            if (parts.Length == 3)  // Ensures the line has the correct format
            {
                entries.Add(new Entry(parts[1], parts[2]) { Date = parts[0] });
            }
        }

        Console.WriteLine("Journal loaded successfully.\n");
    }
}
