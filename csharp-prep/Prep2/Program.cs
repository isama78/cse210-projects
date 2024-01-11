using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage");
        string percentage = Console.ReadLine();
        int perNum = int.Parse(percentage);
        string letter = "";
        if (perNum >= 90)
        {
            letter = "A";
        }
        else if (perNum >= 80)
        {
            letter = "B";
        }
        else if (perNum >= 70)
        {
            letter = "C";
        }
        else if (perNum >= 60)
        {
            letter = "D";
        }
        else if (perNum < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (perNum >= 70)
        {
            Console.WriteLine("You passed!!");
        }
        else
        {
            Console.WriteLine("You will do it better next time");
        }
    }

    
}