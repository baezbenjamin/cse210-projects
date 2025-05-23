using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromtUserName()
        {
            Console.Write("Please enter you name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromtUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }

        DisplayWelcome();
        string userName = PromtUserName();
        int userNumber = PromtUserNumber();
        int square = SquareNumber(userNumber);
        DisplayResult(userName, square);
    }
}