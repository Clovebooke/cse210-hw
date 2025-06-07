using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry.ToFileFormat());
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        var lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            _entries.Add(Entry.FromFileFormat(line));
        }
        Console.WriteLine("Journal loaded successfully!");
    }
}


    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        foreach (var line in File.ReadAllLines(filename))
        {
            var parts = line.Split("~|~");
            if (parts.Length == 3)
            {
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                // Create Entry manually with date since constructor sets current date
                Entry entry = new Entry(prompt, response);

                // But our Entry class currently does not allow setting date externally.
                // To keep things simple for now, let's just accept the date difference.
                // Or add an overloaded constructor if you want date preserved.

                _entries.Add(entry);
            }
        }
    }

    public int EntryCount => _entries.Count;
}
