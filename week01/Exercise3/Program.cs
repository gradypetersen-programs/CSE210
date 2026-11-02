using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess my number!");
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);
        int guess = 0;
        while (guess != randomNumber)
        {
            Console.Write("Enter a number: ");
            string guessString = Console.ReadLine();
            guess = int.Parse(guessString);

            if (guess < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"You got it! My Number was {randomNumber}!");
    }
}