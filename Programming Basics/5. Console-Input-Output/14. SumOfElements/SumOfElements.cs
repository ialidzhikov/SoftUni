using System;
using System.Numerics;

class SumOfElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] splitedNumbers = input.Split(' ');

        int[] array = new int[splitedNumbers.Length];

        for (int i = 0; i < splitedNumbers.Length; i++)
        {
            array[i] = int.Parse(splitedNumbers[i]);
        }

        Decimal sum = 0;
        Decimal diff = 0;
        Decimal bestDiff = Decimal.MaxValue;
        int resultCounter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }
                sum += array[j];
            }
            if (sum == array[i])
            {
                Console.WriteLine("Yes, sum={0}", sum);
                resultCounter++;
                break;
            }
            else
            {
                diff = sum - array[i];
                if (diff <= bestDiff)
                {
                    bestDiff = diff;
                }
            }
            sum = 0;
        }

        if (resultCounter == 0)
        {
            Console.WriteLine("No, diff={0}", Math.Abs(bestDiff));
        }
    }
}

