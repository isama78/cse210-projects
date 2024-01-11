using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName ()
        {
            Console.WriteLine("Please enter your name:");
            string name =Console.ReadLine();
            return name;
        }

        static string PromptUserNumber ()
        {
            Console.WriteLine("Please enter your favorite number:");
            string number =Console.ReadLine();
            return number;
        }

        static int SquareNumber (int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult (string name, int squareNumber)
        {
            Console.Write($"Brother {name}, the square of your number is {squareNumber}");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        string userNumber = PromptUserNumber();
        int parsedNumber = int.Parse(userNumber);
        int squareNumber = SquareNumber(parsedNumber);
        DisplayResult(userName,squareNumber);




    }
}