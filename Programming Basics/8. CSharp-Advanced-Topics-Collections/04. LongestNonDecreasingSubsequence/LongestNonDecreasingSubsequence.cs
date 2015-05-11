using System;
using System.Collections.Generic;
class LongestNonDecreasingSubsequence
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] tokens = input.Split(' ');
        int[] sequence = new int[tokens.Length];
        for (int i = 0; i < sequence.Length; i++)
        {
            sequence[i] = int.Parse(tokens[i]);
        }

        int[] p = new int[sequence.Length];
        int[] m = new int[sequence.Length + 1];

        int maxLength = 0;
        int start = 1;
        int end = maxLength;
        int middle = 0;
        int newLength = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            start = 1;
            end = maxLength;
            while (start <= end)
            {
                middle = (int)Math.Ceiling((start + end) / 2.0);
                if (sequence[m[middle]] <= sequence[i])
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
            }

            newLength = start;

            p[i] = m[newLength - 1];
            m[newLength] = i;

            if (newLength > maxLength)
            {
                maxLength = newLength;
            }
        }

        int[] result = new int[maxLength];
        int k = m[maxLength];
        for (int i = maxLength - 1; i >= 0; i--)
        {
            result[i] = sequence[k];
            k = p[k];
        }

        for (int i = 0; i < maxLength; i++)
        {
            Console.Write("{0} ", result[i]);
        }
        Console.WriteLine();
    }
}
    
