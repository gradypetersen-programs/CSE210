using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment tuesAssignment = new MathAssignment("Howdy Cowboy", "Integrals", "4.6", "7-45");
        Console.WriteLine(tuesAssignment.GetSummary());
        Console.WriteLine(tuesAssignment.GetMathSummary());

        WritingAssignment januaryAssignment = new WritingAssignment("Left-footed Farney", "Nicknames in Colloquial English", "Bills from Williams");
        Console.WriteLine(januaryAssignment.GetSummary());
        Console.WriteLine(januaryAssignment.GetWritingSummary());
    }
}