using System;
using System.Diagnostics;

public class Journal
{
    List<Entry> _entries = new List<Entry>();
    PromptGenerator thePrompt = new PromptGenerator();

    Entry theEntry = new Entry();

    public void AddEntry(Entry theEntry)
    {
        theEntry._promptText = thePrompt.GetRandomPrompt(thePrompt._prompts);
        Console.Write(theEntry._promptText + " ");
        theEntry._entryText = Console.ReadLine();
        theEntry._date = DateTime.Now.ToString("MM/dd/yyyy");
        _entries.Add(theEntry);
    }


    public void DisplayAll()
    {
        foreach (Entry theEntry in _entries)
        {
            theEntry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.Write("What is the filename? ");
        string file = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine("Date,Prompt,Entry");

            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
        Console.WriteLine("Your entries were saved");
    }

    public void LoadFromFile()
    {
        Console.Write("What is the filename? ");
        string file = Console.ReadLine();
        _entries.Clear();

        using (StreamReader reader = new StreamReader(file))
        {
            string headerLine = reader.ReadLine();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] fields = line.Split(',');

                theEntry._date = fields[0];
                theEntry._promptText = fields[1];
                theEntry._entryText = fields[2];

                _entries.Add(theEntry);
            }
        }
        Console.WriteLine("File Loaded");
    }
}