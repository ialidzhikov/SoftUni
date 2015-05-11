using System;
class Pairs
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] tokens = input.Split(' ');

        int[] numbers = new int[tokens.Length];
        for (int i = 0; i < tokens.Length; i++)
        {
            numbers[i] = int.Parse(tokens[i]);    
        }

        int firstPair = numbers[0] + numbers[1];
        int currentPair = 0;
        int diff = 0;
        int maxDiff = int.MinValue;
        bool isPair = true;

        for (int i = 2; i < numbers.Length; i += 2)
        {
            currentPair = numbers[i] + numbers[i + 1];
            if (firstPair != currentPair)
            {
                isPair = false;
                diff = Math.Abs(firstPair - currentPair);
                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }
            }
            firstPair = currentPair;
        }

        if (isPair)
        {
            Console.WriteLine("Yes, value={0}", firstPair);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}

