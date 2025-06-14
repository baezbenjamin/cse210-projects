public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        string stringDuration = Console.ReadLine();
        _duration = int.Parse(stringDuration);
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine(" ");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        ShowSpinner(5);
        Console.WriteLine(" ");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationSymbols = new List<string>();
        animationSymbols = ["|", "/", "—", "\\"];
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string second = animationSymbols[i];
            Console.Write(second);
            Thread.Sleep(600);
            Console.Write("\b \b");
            i++;
            if (i >= animationSymbols.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int second)
    {
        for (int i = second; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("");
    }
}