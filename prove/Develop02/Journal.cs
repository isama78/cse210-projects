using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        //Add an entry to the _entries list
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        //Display the whole entries in the journal
        if(_entries.Count > 0)
        {
            foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        } else{
            Console.WriteLine("Nothing to show...");
        }
    }

    public void SaveToFile(string file)
    {
        //Saves the new entries to an txt file
        string fileName = file;
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}--{entry._promptText}--{entry._entryText}");
            }

        }
    }

    public void LoadFromFile(string file)
    {
        //Loads the txt file in a new session
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        Journal newJournal = new Journal();
        newJournal._entries = new List<Entry>();

        foreach (string line in lines)
        {
            string[] parts = line.Split("--");
            Entry newEntry = new Entry();

            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            AddEntry(newEntry);
        }
    }


}