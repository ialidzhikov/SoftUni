using System;
class PrimeNumberCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        CheckIsItPrime(number);
    }

    private static void CheckIsItPrime(int number)
    {
        bool isPrime = true;

        if (number < 2)
        {
            isPrime = false;
        }
        else
        {
            double length = Math.Sqrt(number);
            for (int i = 2; i < length; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        Console.WriteLine(isPrime ? "true" : "false");
    }
}

