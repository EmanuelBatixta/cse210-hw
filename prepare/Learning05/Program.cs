using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment _mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        WritingAssignment _writingAssignment = new WritingAssignment("Samuel Bennett", "European History", "The Causes of World War II");

        Console.WriteLine(_writingAssignment.GetSummary());
        Console.WriteLine(_writingAssignment.GetWritingInformation());

        Console.WriteLine(_mathAssignment.GetSummary());
        Console.WriteLine(_mathAssignment.GetHomeworkList());
    }
}