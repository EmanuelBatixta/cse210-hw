using System;

class Program
{
    static void Main(string[] args)
    {
        string sNumber = "";
        int iNumber = 1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            sNumber = Console.ReadLine();
            iNumber = int.Parse(sNumber);

            if (iNumber != 0)
            {
            numbers.Add(iNumber);
            }

        }while(iNumber != 0 );

        int count = numbers.Count;
        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");

        int average = sum/count;
        Console.WriteLine($"The average is: {average}");

        int largest = 0;
        foreach (int i in numbers)
        {
            if (i > largest)
            {
                largest = i;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");

        numbers.Sort();
        foreach (int item in numbers)
        {
            Console.WriteLine($"{item}");
        }
    }
}