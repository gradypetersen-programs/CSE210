// Creativity: I learned how to change font color to make menu options 
// make more sense. In addition to the color changes, the user can input 
// either the first word of the menu prompt or the associated number.
// I added an option to save before quitting.
using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        string userSelection = "0";
        Journal userEntry = new Journal();
        while (userSelection != "5" && userSelection != "quit")
        {
            Console.WriteLine("Journal Time! Please select an option below! Type the number or the first word.");
            Console.Write("1. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Make ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("A New Entry");
            Console.Write("2. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Display ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Journal");
            Console.Write("3. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Load ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Journal From File");
            Console.Write("4. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Save");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("5. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Quit");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("> ");

            userSelection = Console.ReadLine().ToLower();

            if (userSelection == "1" || userSelection.Contains("make"))
            {
                Entry newEntry = new Entry();
                RandomPrompt randomPrompt = new RandomPrompt();
                string prompt = randomPrompt.SelectRandomPrompt();
                newEntry._promptText = prompt;
                Console.WriteLine(prompt);
                Console.Write("> ");
                newEntry._userEntry = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                newEntry._date = theCurrentTime.ToShortDateString();
                userEntry._entry = newEntry.CreateString();
                userEntry.AddEntry();
            }

            else if (userSelection == "2" || userSelection.Contains("display"))
            {
                userEntry.Display();
            }

            else if (userSelection == "3" || userSelection.Contains("load"))
            {
                UploadFile newFile = new UploadFile();
                Console.Write("Please enter a file name: ");
                newFile._fileName = Console.ReadLine();
                userEntry._entries = newFile.GetEntries();
                Console.WriteLine($"{newFile._fileName} uploaded! Select display to review entries.");
            }

            else if (userSelection == "4" || userSelection.Contains("save"))
            {
                Write newSave = new Write();
                Console.Write("Please enter a file name: ");
                newSave._fileName = Console.ReadLine();
                newSave._textList = userEntry._entries;
                newSave.WriteFile();
            }

            else if (userSelection == "5" || userSelection.Contains("quit"))
            {
                if (userEntry._entries.Count > 0)
                {
                    Console.WriteLine("Would you like to save? Type 'Yes' or 'No' ");
                    string lastSave = Console.ReadLine().ToLower();
                    if (lastSave == "yes")
                    {
                        Write newSave = new Write();
                        Console.Write("Please enter a file name: ");
                        newSave._fileName = Console.ReadLine();
                        newSave._textList = userEntry._entries;
                        newSave.WriteFile();
                        Console.WriteLine("File Saved!");
                    }
                }
                Console.WriteLine("Thanks for journaling today!");
            }

            else
            {
                Console.WriteLine("You did not select any of the menu options. Please try again");
                Console.Write("Press Enter to continue: ");
                Console.ReadLine();
            }

            Console.WriteLine();
        }

    }
}