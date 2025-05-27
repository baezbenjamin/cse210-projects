using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        string play = "yes";

        Journal journal = new Journal();
        journal._entries = [];

        while (play == "yes")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1.Write\n2.Display\n3.Load\n4.Save\n5.Quit");
            Console.Write("What would you like to do? ");

            string stringOption = Console.ReadLine();
            int option = int.Parse(stringOption);

            if (option == 1)
            {
                PromtGenerator newPromt = new PromtGenerator();
                DateTime theCurrentTime = DateTime.Now;
                Entry entry = new Entry();

                entry._promtText = newPromt.GetRandomPrompt();
                Console.WriteLine(entry._promtText);
                entry._entryText = Console.ReadLine();
                entry._date = theCurrentTime.ToShortDateString();

                journal.AddEntry(entry);
            }
            else if (option == 2)
            {
                journal.DisplayAll();
            }
            else if (option == 3)
            {
                Console.WriteLine("OK 3");
            }
            else if (option == 4)
            {
                Console.WriteLine("OK 4");
            }
            else if (option == 5)
            {
                play = "no";
            }
        }
    }
}