using System.IO;
public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
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
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date} - Promt: {entry._promtText}\n{entry._entryText}");
                outputFile.WriteLine(" ");
            }
        }
    }

    public void LoadFromFile(string file)
    {

        string[] lines = System.IO.File.ReadAllLines(file);
        for (int i = 0; i < lines.Length; i++)
        {
            Entry entry = new Entry();
            string firstLine = lines[i];
            string[] firstLineParts = firstLine.Split(" ");
            entry._date = firstLineParts[1];
            int firstLineLength = firstLineParts.Count();
            string promtText = "";
            for (int j = 4; j < firstLineLength; j++)
            {
                if (promtText == "")
                {
                    promtText = firstLineParts[j];
                }
                else
                {
                    promtText = promtText + " " + firstLineParts[j];
                }
            }
            entry._promtText = promtText;
            i += 1;
            string secondLine = lines[i];
            string[] secondLineParts = secondLine.Split(" ");
            int secondLineLength = secondLineParts.Count();
            string entryText = "";
            for (int k = 0; k < secondLineLength; k++)
            {
                if (entryText == "")
                {
                    entryText = secondLineParts[k];
                }
                else
                {
                    entryText = entryText + " " + secondLineParts[k];
                }
            }
            entry._entryText = entryText;
            AddEntry(entry);
            i += 1;
        }
    }

}