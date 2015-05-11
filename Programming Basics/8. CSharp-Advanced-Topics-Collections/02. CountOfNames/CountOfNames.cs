using System;
using System.Collections.Generic;
class CountOfNames
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] names = input.Split(' ');

        SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
        for (int i = 0; i < names.Length; i++)
        {
            if (dictionary.ContainsKey(names[i]))
            {
                dictionary[names[i]]++;
            }
            else
            {
                dictionary.Add(names[i], 1);
            }
        }

        foreach (var pair in dictionary)
        {
            Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
        }
    }
}

