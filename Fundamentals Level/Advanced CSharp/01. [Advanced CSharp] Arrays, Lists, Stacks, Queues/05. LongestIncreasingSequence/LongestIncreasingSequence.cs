using System;
using System.Collections.Generic;

class LongestIncreasingSequence
{
    static void Main()
    {
        string inputLine = Console.ReadLine();

        string[] numbersAsStrings = inputLine.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[numbersAsStrings.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(numbersAsStrings[i]);
        }

        int bestCount = int.MinValue;
        int bestCountIndex = int.MinValue;
        List<List<int>> increasingSequences = new List<List<int>>();
        int sequencesIndex = 0;
        bool isInIncreasingSequence = false;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] >= numbers[i + 1])
            {
                if (isInIncreasingSequence == false)
                {
                    increasingSequences.Add(new List<int>());
                    increasingSequences[sequencesIndex].Add(numbers[i]);
                }
                else
                {
                    increasingSequences[sequencesIndex].Add(numbers[i]);
                }
                
                if (increasingSequences[sequencesIndex].Count > bestCount)
                {
                    bestCount = increasingSequences[sequencesIndex].Count;
                    bestCountIndex = sequencesIndex;
                }
                sequencesIndex++;
                isInIncreasingSequence = false;
            }
            else
            {
                if (isInIncreasingSequence == false)
                {
                    increasingSequences.Add(new List<int>());
                    increasingSequences[sequencesIndex].Add(numbers[i]);
                    isInIncreasingSequence = true;
                }
                else
                {
                    increasingSequences[sequencesIndex].Add(numbers[i]);
                }
            }
        }

        if (isInIncreasingSequence)
        {
            increasingSequences[sequencesIndex].Add(numbers[numbers.Length - 1]);

            if (increasingSequences[sequencesIndex].Count > bestCount)
            {
                bestCount = increasingSequences[sequencesIndex].Count;
                bestCountIndex = sequencesIndex;
            }
        }
        else
        {
            increasingSequences.Add(new List<int>());
            increasingSequences[sequencesIndex].Add(numbers[numbers.Length - 1]);
        }

        foreach (List<int> increasingSequence in increasingSequences)
        {
            foreach (int member in increasingSequence)
            {
                Console.Write("{0} ", member);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Longest: {0}", String.Join(" ", increasingSequences[bestCountIndex]));
    }
}

