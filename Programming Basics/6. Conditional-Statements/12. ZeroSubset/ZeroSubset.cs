using System;
class ZeroSubset
{
    const int SIZE = 5;

    static int resultCount = 0;
    static void Main()
    {
        string input = Console.ReadLine();
        string[] tokens = input.Split(' ');
        int[] numbers = new int[SIZE];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(tokens[i]);
        }

        int index = 0;
        for (int i = 2; i <= SIZE; i++)
        {
            int[] vector = new int[i];
            GenerateVariation(vector, numbers, index, 0);    
        }

        if (resultCount == 0)
        {
            Console.WriteLine("no zero subset");
        }
    }

    private static void GenerateVariation(int[] vector, int[] numbers,int index, int start)
    {
        if (index >= vector.Length && IsSumEqualToZero(vector))
        {
            PrintVector(vector);
            resultCount++;
        }
        else if (index < vector.Length)
        {
            for (int i = start; i < SIZE; i++)
            {
                vector[index] = numbers[i];
                GenerateVariation(vector, numbers, index + 1, i + 1);
            }
        }
    }

    private static void PrintVector(int[] vector)
    {
        for (int i = 0; i < vector.Length; i++)
        {
            if (i == 0)
            {
                Console.Write("{0} ", vector[i]);
            }
            else
            {
                Console.Write("+ {0} ", vector[i]);
            }
        }
        Console.WriteLine("= 0");
    }

    private static bool IsSumEqualToZero(int[] vector)
    {
        int sum = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            sum += vector[i];
        }

        if (sum == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

