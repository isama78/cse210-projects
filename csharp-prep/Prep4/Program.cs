using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string number;
        int parsedNumber = -1;
        while (parsedNumber != 0)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("Enter a number");
                number = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Enter another number");
                number = Console.ReadLine();
            }
            if (number != "0")
            {
                parsedNumber = int.Parse(number);
                numbers.Add(parsedNumber);
            }
            parsedNumber = int.Parse(number);
        }
        int sum = 0;
        for (int i = 0; i <= numbers.Count - 1; i++)
        {
            sum += numbers[i];
        }
        double avg = (double)sum / numbers.Count;
        int max = 0;
        foreach (int numb in numbers)
        {
            if (max < numb)
            {
                max = numb;
            }
        }

        Console.WriteLine($"The sum of numbers is {sum}");
        Console.WriteLine($"The average of numbers is {avg}");
        Console.Write($"the largest number is {max}");

    }
}