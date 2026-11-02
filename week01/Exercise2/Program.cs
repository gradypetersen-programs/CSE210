using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the assignment grade as a percentage. ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        string letterGrade;
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // determines + or -
        double gradeDouble = grade;
        double tens = Math.Floor(gradeDouble / 10) * 10;
        int tensInt = Convert.ToInt32(tens);
        int ones = grade - tensInt;
        string gradeSign = "";
        if (ones >= 7)
        {
            gradeSign = "+";
        }
        else if (ones < 3)
        {
            gradeSign = "-";
        }
        if (grade == 100)
        {
            gradeSign = "";
        }

        if (letterGrade == "F")
        {
            Console.WriteLine($"The grade is {letterGrade}.");
        }
        else if (letterGrade != "A")
        {
            Console.WriteLine($"The grade is {letterGrade}{gradeSign}.");
        }
        else
        {
            if (gradeSign == "+")
            {
                gradeSign = "";
            }

            Console.WriteLine($"The grade is {letterGrade}{gradeSign}.");
        }
    }
    
}