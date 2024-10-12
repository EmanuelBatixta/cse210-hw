class Grades
{
    private string realGrade = "";
    private string realSymbol = "";
    private int minGrade = 70;
    private int numVersion = 0;

    public void SetGrade()
    {
        Console.WriteLine("What's your grade percentage?");
        string grade = Console.ReadLine();
        numVersion = int.Parse(grade);
    }

    public void RealGrade()
    {
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
    }

    public void RealSymbol()
    {
        if (realGrade != "A" && realGrade != "F")
        {
            if (numVersion % 10 >= 3)
            {
                realSymbol = "+";
            }
            else if (numVersion % 10 <= 7)
            {
                realSymbol = "-";
            }
            else
            {
                realSymbol = "";
            }
        }
    }

    public void Result()
    {
        Console.WriteLine($"Your grade is {realGrade}{realSymbol}.");

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