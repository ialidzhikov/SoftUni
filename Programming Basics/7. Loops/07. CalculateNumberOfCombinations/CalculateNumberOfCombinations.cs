using System;
using System.Numerics;
class CalculateNumberOfCombinations
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger numerator = 1;
        for (int i = k + 1; i <= n; i++)
        {
            numerator *= i;    
        }

        BigInteger denominator = 1;
        for (int i = 2; i <= n - k; i++)
        {
            denominator *= i;
        }

        Console.WriteLine("{0}", numerator / denominator);
    }
}

