using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Grade Percentage: ");
        string gradePer = Console.ReadLine();
        int gradeNumber = int.Parse(gradePer);
        string letter = "";

        if (gradeNumber >= 90)
        {
            letter = "A";
        }

        else if (gradeNumber >= 80)
        {
            letter = "B";
        }

        else if (gradeNumber >= 70)
        {
            letter = "C";
        }

        else if (gradeNumber >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Letter Grade: {letter}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations! You have passed the class!");
        }

        else
        {
            Console.WriteLine("You didn't pass the class, cheer up for the next one!");
        }
    }
}