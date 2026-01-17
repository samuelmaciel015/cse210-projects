using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        for (int i = 0; i < _entries.Count(); i++)
        {
            Console.WriteLine($"Date: {_entries[i]._date} - Prompt:{_entries[i]._promptText}\n{_entries[i]._entryText}\n");
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            for (int i = 0; i < _entries.Count(); i++)
            {
                outputFile.WriteLine($"Date: {_entries[i]._date} - Prompt:{_entries[i]._promptText}\n{_entries[i]._entryText}\n");

            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}