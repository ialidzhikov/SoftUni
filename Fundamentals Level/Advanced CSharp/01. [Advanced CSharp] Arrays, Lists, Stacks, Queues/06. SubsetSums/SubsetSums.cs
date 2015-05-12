using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSums
{
    static void Main()
    {
        int targetSum = int.Parse(Console.ReadLine());
        string inputLine = Console.ReadLine();

        string[] numbersAsStrings = inputLine.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        List<int> numbers = new List<int>(numbersAsStrings.Length);
        int numberToAdd = 0;
        for (int i = 0; i < numbersAsStrings.Length; i++)
        {
            numberToAdd = int.Parse(numbersAsStrings[i]);
            if (!numbers.Contains(numberToAdd))
            {
                numbers.Add(numberToAdd);
            }
        }

        int currentSum = 0;
        bool hasMatchinSubsetSum = false;
        bool isFirstElement = true;
        int[] mask = new int[numbers.Count];
        while (GenerateNextMask(mask))
        {
            currentSum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (mask[i] == 1)
                {
                    currentSum += numbers[i];
                }
            }
            if (currentSum == targetSum)
            {
                hasMatchinSubsetSum = true;
                isFirstElement = true;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (mask[i] == 1)
                    {
                        if (isFirstElement)
                        {
                            Console.Write("{0} ", numbers[i]);
                            isFirstElement = false;
                        }
                        else
                        {
                            Console.Write(" + {0}", numbers[i]);
                        }
                    }
                }
                Console.WriteLine(" =  {0}", currentSum);
            }
        }
        if (!hasMatchinSubsetSum)
        {
            Console.WriteLine("No matching subset.");
        }
    }

    private static bool GenerateNextMask(int[] mask)
    {
        int i = 0;
        for (; i < mask.Length ; i++)
        {
            if (mask[i] != 0)
            {
                mask[i] = 0;
            }
            else
            {
                break;
            }
        }

        if (i < mask.Length)
        {
            mask[i] = 1;
            return true;
        }
        return false;
    }
}

