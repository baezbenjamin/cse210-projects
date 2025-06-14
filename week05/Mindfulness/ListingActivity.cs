using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountDown(6);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine("");
        Console.WriteLine($"You have listed {_count} items");
        Console.WriteLine("");
    }
    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        Console.WriteLine($"--- {randomPrompt} ---");
    }
}