using System;
class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] sequence = new int[n * 2];
        for (int i = 0; i < n * 2; i++)
        {
            sequence[i] = int.Parse(Console.ReadLine());
        }

        int firstSubsequence = 0;
        int secondSubsequence = 0;
        for (int i = 0; i < n; i++)
        {
            firstSubsequence += sequence[i];
            secondSubsequence += sequence[n + i];
        }

        if (firstSubsequence == secondSubsequence)
        {
            Console.WriteLine("Yes, sum={0}", firstSubsequence);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(firstSubsequence - secondSubsequence));
        }
    }
}

