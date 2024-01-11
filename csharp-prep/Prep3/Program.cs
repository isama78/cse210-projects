using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 11);
        int parsedNUmber;
        do
        {
            Console.WriteLine("Guess the magic number");
            string number = Console.ReadLine();
            parsedNUmber = int.Parse(number);
            {
                if (parsedNUmber > randomNumber)
                {
                    Console.WriteLine("lower");
                }
                else if (parsedNUmber < randomNumber)
                {
                    Console.WriteLine("higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
        } while (parsedNUmber != randomNumber);


    }
}