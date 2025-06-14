using System;

class Program
{
    static void Main(string[] args)
    {
        string confirmation = "yes";
        while (confirmation == "yes")
        {
            Console.Clear();
            Console.WriteLine("Hello World! This is the Mindfulness Project.");
            Console.Write("Menu Options:\n1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit\nSelect a choise from the menu: ");
            string option = Console.ReadLine();
            Console.Clear();
            if (option == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
            }
            else if (option == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
            }
            else if (option == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DisplayStartingMessage();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }
            else if (option == "4")
            {
                confirmation = "no";
            }
        }

    }
}