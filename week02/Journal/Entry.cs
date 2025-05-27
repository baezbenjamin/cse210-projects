public class Entry
{
    public string _date;
    public string _promtText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Promt: {_promtText}\n{_entryText}");
        Console.WriteLine(" ");
    }
}