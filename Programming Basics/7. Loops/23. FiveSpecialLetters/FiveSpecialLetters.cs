using System;
using System.Collections.Generic;
using System.Linq;
class FiveSpecialLetters
{
    const int SIZE = 5;
    static int resultCount = 0;
    static char[] sequence = { 'a', 'b', 'c', 'd', 'e' };
    static Dictionary<char, int> weights = new Dictionary<char, int>()
    {
        {'a', 5}, {'b', -12}, {'c', 47}, {'d', 7}, {'e', -32},
    };
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        int index = 0;
        char[] vector = new char[SIZE];
        GenerateVariations(vector, index, start, end);

        if (resultCount == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static void GenerateVariations(char[] vector, int index, int start, int end)
    {
        if (index >= SIZE)
        {
            if (start <= CalculateWeight(vector) && CalculateWeight(vector) <= end)
            {
                Print(vector);
                resultCount++;
            }
        }
        else
        {
            for (int i = 0; i < SIZE; i++)
            {
                vector[index] = sequence[i];
                GenerateVariations(vector, index + 1, start, end);
            }
        }
    }

    private static void Print(char[] vector)
    {
        for (int i = 0; i < SIZE; i++)
        {
            Console.Write(vector[i]);
        }
        Console.Write(' ');
    }

    private static int CalculateWeight(char[] vector)
    {
        vector = RemoveDuplicates(vector);
        
        int value;
        int i = 1;
        int weight = 0;
        foreach (var key in vector)
        {
            if (weights.TryGetValue(key, out value))
	        {
                weight += i * value;
	        }
            i++;
        }
        return weight;
    }

    private static char[] RemoveDuplicates(char[] vector)
    {
        return vector.Distinct().ToArray();
    }
}

