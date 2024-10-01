using System;

public class Journal
{
    public List<Entry> _entries;

    /*public void AddEntry(Entry newEntry)
    {
        Console.Write(newEntry._promptText + " ");
        newEntry._entryText = Console.ReadLine();
        newEntry._date = DateTime.Now.ToString("MM/dd/yyyy");
        _entries.Add(new Entry(newEntry._date, newEntry._promptText, newEntry._entryText));
    }

    /*Display entries
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.Display());
        }
    }

    /*Save Entry to a File
    public void SaveToFile(string file)
    {
        Console.Write("What is the filename? ");
        file = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine("Date,Prompt,Entry");

            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}"); ")
            }
        }
        Console.WriteLine("Your entries were saved");
    }

    /*Load Entry from Exisiting saved File
    public void LoadFromFile(string file)
    {
        Console.Write("What is the filename? ");
        file = Console.ReadLine();
        _entries.Clear();

        using (StreamReader reader = new StreamReader(file))
        {
            string headerLine = reader.ReadLine();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] fields = line.Split(',');

                string _date = fields[0];
                string _promptText = fields[1];
                string _entryText = fields[2];

                _entries.Add(new Entry(_date, _promptText, _entryText));
            }
        }
        Console.WriteLine("File Loaded");
    }*/
}