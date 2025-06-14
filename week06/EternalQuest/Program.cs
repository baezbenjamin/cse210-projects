using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nYou have (points) points.\n");
        Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
        Console.Write("Select a choice from the menu: ");
        Console.ReadLine();
        // Option 1
        Console.WriteLine("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        Console.ReadLine();
        Console.Write("What is the name of youir goal? ");
        Console.ReadLine();
        Console.Write("What is a short description of it? ");
        Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        Console.ReadLine();
        // Option 2
        Console.WriteLine("The goals are:");
        Console.WriteLine("(Number). ([ ]) (Goal) ((Description))");
        // Option 3
        Console.Write("What is the filename for the goal file? ");
        Console.ReadLine();
        // Option 4
        Console.Write("What is the filename for the goal file? ");
        Console.ReadLine();
        // Option 5
        Console.WriteLine("The goals are:");
        Console.Write("Which goal did you accomplish");
        Console.WriteLine("Congratulations! You have earned 50 points!");
        Console.WriteLine("You now have (points) points.");
    }
}