using System;
class NumbersIIntervalDividableByGivenNumber
{
    static void Main()
    {
        int lowerLimit = int.Parse(Console.ReadLine());
        int upperLimit = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = lowerLimit; i <= upperLimit; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}

