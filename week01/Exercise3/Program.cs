using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string magic = Console.ReadLine();
        // int magicNumber = int.Parse(magic);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        int a = 0;
        int b = 1;

        while (a != b)
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int guessNumber = int.Parse(guess);


            if (guessNumber == number)
            {
                Console.WriteLine("You guessed it!");
                a = 1;
            }
            else if (guessNumber <= number)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber >= number)
            {
                Console.WriteLine("Lower");
            }
        }
    }
}