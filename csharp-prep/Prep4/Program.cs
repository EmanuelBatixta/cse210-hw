using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        Numbers numbers = new Numbers();

        numbers.AddNumbers();
        int sum = numbers.SumS();
        float average = numbers.Averages();
        int largest = numbers.LargestNum();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max: {largest}");

        // int smallest = -1;
        // foreach(int i in numbers)
        // {
        //     if (i < smallest && i > 0)
        //     {
        //         smallest = i;
        //     }
        // }
        // Console.WriteLine($"The smallest number is: {smallest}");

        // numbers.Sort();
        // Console.WriteLine("The sorted list is:");
        // foreach (int item in numbers)
        // {
        //     Console.WriteLine($"{item}");
        // }
    }
}