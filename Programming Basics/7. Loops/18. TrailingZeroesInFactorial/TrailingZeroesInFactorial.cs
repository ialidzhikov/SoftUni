using System;
class TrailingZeroesInFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int trailingZeroes = 0;
        for (int i = 5; i < n; i *= 5)
        {
            trailingZeroes += n / i;
        }

        Console.WriteLine(trailingZeroes);
    }
}

