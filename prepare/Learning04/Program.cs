using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment newAssingment = new Assignment("Mauro Isa", "Programming");
        Console.WriteLine(newAssingment.GetSummary());
        MathAssignment newMathAssignment = new MathAssignment("Mauro Isa", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(newMathAssignment.GetHomeworkList());
        WritingAssignment newWritingAssignment = new WritingAssignment("Mauro Isa", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(newWritingAssignment.GetWritingInformation());
    }
}