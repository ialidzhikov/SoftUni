using System;
class PrimeChecker
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());

        bool isPrime = IsPrime(n);
        Console.WriteLine(isPrime);
    }

    private static bool IsPrime(ulong n)
    {
        if (n == 0 || n == 1)
        {
            return false;
        }
        else if (n > 2)
        {
            for (ulong i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
        }
        return true;
    }
}

