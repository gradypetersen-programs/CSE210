using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        do
        {
            Console.Write("Please enter a number (0 to quit): ");
            string numberString = Console.ReadLine();
            number = int.Parse(numberString);
            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        int total = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            total = total + numbers[i];
        }

        int largest = 0;
        foreach (int i in numbers)
        {
            if (i > largest)
            {
                largest = i;
            }
        }
        
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {(float)total / numbers.Count}");
        Console.WriteLine($"The largest number is is: {largest}");


    }
}