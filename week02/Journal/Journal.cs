using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entriesList = new List<Entry>();

    private List<string> _dailyPrompts = new List<string>
    {
        "Who inspired you today?",
        "What brought you joy today?",
        "How did you feel spiritually today?",
        "What challenged you the most today?",
        "If you could change one thing about today, what would it be?"
    };

    public void AddEntry()
    {
        Random rng = new Random();
        string prompt = _dailyPrompts[rng.Next(_dailyPrompts.Count)];

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your answer: ");
        string answer = Console.ReadLine();

        string currentDate = DateTime.Now.ToString("MM/dd/yyyy");
        Entry newEntry = new Entry(currentDate, prompt, answer);
        _entriesList.Add(newEntry);
    }

    public void ShowJournal()
    {
        Console.WriteLine("\n--- All Journal Entries ---");
        foreach (Entry e in _entriesList)
        {
            e.ShowEntry();
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter filename to save journal: ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry e in _entriesList)
            {
                writer.WriteLine($"{e._entryDate}|{e._question}|{e._answer}");
            }
        }

        Console.WriteLine("Journal successfully saved!");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter filename to load journal: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            _entriesList.Clear();
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry loadedEntry = new Entry(parts[0], parts[1], parts[2]);
                    _entriesList.Add(loadedEntry);
                }
            }

            Console.WriteLine("Journal successfully loaded!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
