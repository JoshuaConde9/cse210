//Iterate through all entries in the journal and display them to the screen.

//Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.

//Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.

using System;

public class JournalEntries
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._entryDate:f}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Entry: {entry._entry}");
            Console.WriteLine("-------------------------");
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"Date: {entry._entryDate:f}");
                writer.WriteLine($"Prompt: {entry._prompt}");
                writer.WriteLine($"Entry: {entry._entry}");
                writer.WriteLine("-------------------------");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _entries.Clear();

        string[] lines = File.ReadAllLines(fileName);
        Entry currentEntry = null;

        foreach (string line in lines)
        {
            if (line.StartsWith("Date:"))
            {
                currentEntry = new Entry();
                currentEntry._entryDate = DateTime.Parse(line.Substring(6));
            }
            else if (line.StartsWith("Prompt:"))
            {
                currentEntry._prompt = line.Substring(8);
            }
            else if (line.StartsWith("Entry:"))
            {
                currentEntry._entry = line.Substring(7);
            }
            else if (line.StartsWith("-------------------------") && currentEntry != null)
            {
                _entries.Add(currentEntry);
                currentEntry = null;
            }
        }
    }
}

// I learned about .StartsWith and .Substring while creating this class