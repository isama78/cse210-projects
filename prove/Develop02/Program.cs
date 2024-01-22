using System;
using System.Collections.Generic;

class Program
{
    // Excecutes the main menu
    static void Main(string[] args)
    {
        Journal newJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator._prompts.Add("Who was the most interesting person I interacted with today?");
        promptGenerator._prompts.Add("What was the best part of my day?");
        promptGenerator._prompts.Add("How did I see the hand of the Lord in my life today?");
        promptGenerator._prompts.Add("What was the strongest emotion I felt today?");
        promptGenerator._prompts.Add("If I had one thing I could do over today, what would it be?");

        string fileName;
        int number = -1;
        while (number != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1- Write");
            Console.WriteLine("2- Display");
            Console.WriteLine("3- Load");
            Console.WriteLine("4- Save");
            Console.WriteLine("5- Quit");
            Console.WriteLine("What would you like to do?");
            string userChoice = Console.ReadLine();
            
            if (!int.TryParse(userChoice, out number))
            {
                Console.WriteLine("Please, enter a valid option");
                Console.WriteLine("");
                continue;
            } else if (number > 5)
            {
                Console.WriteLine("Please, enter one of the options shown above");
                Console.WriteLine("");
                continue;
            }

            if (number == 1)
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry anEntry = new Entry();
                string promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine(promptText);
                anEntry._entryText = Console.ReadLine();
                anEntry._date = dateText;
                anEntry._promptText = promptText;
                newJournal.AddEntry(anEntry);
                anEntry.Display();
            } else if (number == 2)
            {
                newJournal.DisplayAll();
            } else if (number == 3)
            {
                Console.WriteLine("Enter the file name");
                fileName = Console.ReadLine();
                newJournal.LoadFromFile(fileName);
            } else if (number == 4)
            {
                Console.WriteLine("Enter the file name");
                fileName = Console.ReadLine();
                newJournal.SaveToFile(fileName);
            }
        }




    }
}