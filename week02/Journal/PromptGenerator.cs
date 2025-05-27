using System;
using System.Collections.Generic;
public class PromtGenerator
{
    public List<string> _promts = new List<string> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What is one goal I can set for tomorrow?", "How did I work toward my goals today?"};

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(_promts.Count);
        string randomPrompt = _promts[randomIndex];
        return $"{randomPrompt}";
    }
}