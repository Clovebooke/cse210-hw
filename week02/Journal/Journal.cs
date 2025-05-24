using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new();

    public void AddEntry(string prompt, string response)
    {
        entries.Add(new Entry(prompt, response));
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using StreamWriter writer = new(filename);
        foreach (var entry in entries)
        {
            writer.WriteLine(entry.ToFileFormat());
        }
        Console.WriteLine("Journal saved.");
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        foreach (var line in File.ReadLines(filename))
        {
            var entry = Entry.FromFileFormat(line);
            if (entry != null)
            {
                entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded.");
    }
}
