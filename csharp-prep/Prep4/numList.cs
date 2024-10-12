class Numbers
{
    private string sNumber = "";
    private int iNumber = 1;
    private List<int> numberList = new List<int>();
    private int sum = 0;
    private int largest = 0;
    private float average;

    public void AddNumbers()
    {
        do
        {
            Console.Write("Enter number: ");
            sNumber = Console.ReadLine();
            iNumber = int.Parse(sNumber);

            if (iNumber != 0)
            {
                numberList.Add(iNumber);
            }

        }while(iNumber != 0 );
    }

    public int SumS()
    {
        foreach (int num in numberList)
        {
            sum += num;
        }
        return sum;
    }

    public int LargestNum()
    {
        foreach (int i in numberList)
        {
            if (i > largest)
            {
                largest = i;
            }
        }
        return largest;
    }

    public float Averages()
    {
        average = ((float)sum)/numberList.Count;
        return average;
    }

}