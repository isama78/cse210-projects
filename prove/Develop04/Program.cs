using System;

class Program
{
    static void Main(string[] args)
    {
        //Parameter to Listing Activity
        List<string> listingPrompts = new List<string>() {"Who are people that you appreciate?", "What are personal strengths of yours?","Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};

        List<string> reflectingPrompts = new List<string>() { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };

        List<string> reflectinQuestions = new List<string>() { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };

        int parsedChoice = 0;

        while (parsedChoice != 4)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1 - Start Breathing Activity");
            Console.WriteLine("2 - Start Reflecting Activity");
            Console.WriteLine("3 - Start Listing Activity");
            Console.WriteLine("4 - Quit");
            string userChoice = Console.ReadLine();
            parsedChoice = int.Parse(userChoice);

            if (parsedChoice == 1)
            {
                BreathingActivity newActivity = new BreathingActivity("breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

                newActivity.Run();
            }
            else if (parsedChoice == 2)
            {
                ReflectingActivity newActivity = new ReflectingActivity("reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", reflectingPrompts, reflectinQuestions);

                newActivity.Run();
            }
            else if (parsedChoice == 3)
            {
                ListingActivity newActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", listingPrompts);

                newActivity.Run();
            }
            else
            {
                Console.WriteLine("Please, select a valid option");
            }
        }
    }
}