using System;
using System.Collections.Generic;
using System.Linq;

class CouplesFrequency
{
    static void Main()
    {
        int[] numbers =
            Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        Dictionary<Tuple<int, int>, int> frequenciesDictionary = new Dictionary<Tuple<int, int>, int>();

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            Tuple<int, int> currentTuple = new Tuple<int, int>(numbers[i], numbers[i + 1]);
            if (!frequenciesDictionary.ContainsKey(currentTuple))
            {
                frequenciesDictionary.Add(currentTuple, 1);
            }
            else
            {
                frequenciesDictionary[currentTuple]++;
            }
        }

        foreach (KeyValuePair<Tuple<int, int>, int> pair in frequenciesDictionary)
        {
            Console.WriteLine("{0} {1} -> {2:F2}%", pair.Key.Item1, pair.Key.Item2, ((double)(pair.Value) / (numbers.Length - 1) * 100));
        }
    }
}

