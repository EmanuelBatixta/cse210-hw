using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your grade percentage?");
        string grade = Console.ReadLine();
        int numVersion = int.Parse(grade);

        string realGrade = "";

        if (numVersion >= 90)
        {
            realGrade = "A";
        }
        else if (numVersion >= 80)
        {
            realGrade = "B";
        }
        else if (numVersion >= 70)
        {
            realGrade = "C";
        }
        else if (numVersion >= 60)
        {
            realGrade = "D";
        }
        else
        {
            realGrade = "F";
        }

        int minGrade = 70;
        
        // string symbolGrade = "";

        // if (numVersion[1] >= "7" && numVersion != "A" || numVersion != "F")
        // {
        //     symbolGrade = "+";
        // }
        // else if (numVersion[1] < 3 && numVersion != "F")
        // {
        //     symbolGrade = "-";
        // }

        Console.WriteLine($"Your grade is {realGrade}.");

        if (minGrade > numVersion)
        {
            Console.WriteLine("Sorry, you don't pass this time, almost. If you study a little more you will pass in the next!");
        }
        else
        {
            Console.WriteLine("Congratulation's you passed!!");
        }

    }
}