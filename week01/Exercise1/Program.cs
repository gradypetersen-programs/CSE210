using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine();
        Console.Write("What is your first name? ");
        string givenName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"My name is {lastName}, {givenName} {lastName}.");
    }
}