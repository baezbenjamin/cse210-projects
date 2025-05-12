using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers;
        numbers = new List<int>();
        int number = -1;
        int count = 0;
        float total = 0;
        int largest = 0;
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
                count += 1;
                total += number;
                if (number > largest)
                {
                    largest = number;
                }
            }
        }
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {total / count}");
        Console.WriteLine($"The largest is: {largest}");
    }
}