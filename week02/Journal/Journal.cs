using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        int i = _entries.Count;
        if (i == 0)
        {
            _entries.Add(newEntry);
        }
        else
        {
            _entries.Insert(i, newEntry);
        }
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine("DATE,PROMPT,ENTRY");

            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        using (StreamReader reader = new StreamReader(file))
        {
            string headerLine = reader.ReadLine();

            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    Console.WriteLine($"Date: {parts[0]} - Prompt: {parts[1]}");
                    Console.WriteLine(parts[2]);
                    Console.WriteLine();
                }
            }
        }
    }
}