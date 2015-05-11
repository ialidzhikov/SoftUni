using System;
using System.Collections.Generic;
class JoinLists
{
    static void Main()
    {
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();

        string[] firstTokens = firstInput.Split(' ');
        string[] secondTokens = secondInput.Split(' ');
        int[] firstNumbers = new int[firstTokens.Length];
        int[] secondNumbers = new int[secondTokens.Length];

        for (int i = 0; i < firstNumbers.Length; i++)
        {
            firstNumbers[i] = int.Parse(firstTokens[i]);
        }
        for (int i = 0; i < secondNumbers.Length; i++)
        {
            secondNumbers[i] = int.Parse(secondTokens[i]);
        }

        List<int> firstList = new List<int>(firstNumbers);
        List<int> secondList = new List<int>(secondNumbers);

        List<int> removedFirstList = RemoveDuplicates(firstList);
        List<int> removedSecondList = RemoveDuplicates(secondList);

        List<int> sortedFirstList = SortList(removedFirstList);
        List<int> sortedSecondList = SortList(removedSecondList);

        List<int> result = Join(sortedFirstList, sortedSecondList);
        PrintList(result);
    }

    private static void PrintList(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write("{0} ", list[i]);
        }
        Console.WriteLine();
    }

    private static List<int> Join(List<int> firstList, List<int> secondList)
    {
        List<int> joined = new List<int>(firstList.Count + secondList.Count);
        int firstIndex = 0;
        int secondIndex = 0;
        while (firstIndex < firstList.Count && secondIndex < secondList.Count)
        {
            if (firstList[firstIndex] < secondList[secondIndex])
            {
                joined.Add(firstList[firstIndex]);
                firstIndex++;
            }
            else if (firstList[firstIndex] > secondList[secondIndex])
            {
                joined.Add(secondList[secondIndex]);
                secondIndex++;
            }
            else
            {
                joined.Add(firstList[firstIndex]);
                firstIndex++;
                secondIndex++;
            }
        }

        if (firstIndex < firstList.Count)
        {
            joined.Add(firstList[firstIndex]);
            firstIndex++;
        }
        else if (secondIndex < secondList.Count)
        {
            joined.Add(secondList[secondIndex]);
            secondIndex++;
        }

        return joined;
    }

    private static List<int> SortList(List<int> list)
    {
        int temp = 0;
        int minIndex = 0;
        for (int i = 0; i < list.Count - 1; i++)
        {
            minIndex = i;
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[minIndex] > list[j])
                {
                    minIndex = j;                    
                }
            }
            if (minIndex != i)
            {
                temp = list[i];
                list[i] = list[minIndex];
                list[minIndex] = temp;
            }
        }
        return list;
    }

    private static List<int> RemoveDuplicates(List<int> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[i] == list[j])
                {
                    list.RemoveAt(j);
                }
            }
        }
        return list;
    }
}

