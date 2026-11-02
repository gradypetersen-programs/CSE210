using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int numberSquared = SquareNumber(userNumber);

        DisplayResult(userName, numberSquared);
        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name! ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter a number! ");
            string userNumberString = Console.ReadLine();
            int userNumber = int.Parse(userNumberString);
            return userNumber;
        }

        static int SquareNumber(int number)
        {
            int newNumber = number * number;
            return newNumber;
        }

        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}.");
        }
    }
}