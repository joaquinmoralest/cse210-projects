using System.IO;

public class Journal()
{
    public List<Entry> _entries = new List<Entry>();
    string fileName = "journal.txt";

    public void Save()
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date} | Prompt: {entry._prompt} | {entry._text}");
            }
        }

        Console.WriteLine("Saved!");
    }

    public void Load()
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Entry newEntry = new Entry();
            string[] parts = line.Split("|");

            string textDate = parts[0].TrimStart().TrimEnd();
            string[] dateParts = textDate.Split(":");
            string date = dateParts[1].TrimStart().TrimEnd();

            string textPrompt = parts[1].TrimStart().TrimEnd();
            string[] promptParts = textPrompt.Split(":");
            string prompt = promptParts[1].TrimStart().TrimEnd();

            newEntry._date = date;
            newEntry._prompt = prompt;
            newEntry._text = parts[2].TrimStart().TrimEnd();
            _entries.Add(newEntry);
        }

        Console.WriteLine("Loaded!");
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine();
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}");
            Console.WriteLine($"{entry._text}");
            Console.WriteLine();
        }
    }
}