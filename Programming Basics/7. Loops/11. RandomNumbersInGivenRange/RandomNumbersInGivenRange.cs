using System;
class RandomNumbersInGivenRange
{
    static Random randomGenerator = new Random();
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", randomGenerator.Next(min, max + 1));
        }
        Console.WriteLine();
    }
}

