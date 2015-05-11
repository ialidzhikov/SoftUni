using System;
using System.Collections.Generic;
class PrimesInGivenRange
{
    static void Main()
    {
        int startPosition = int.Parse(Console.ReadLine());
        int endPosition = int.Parse(Console.ReadLine());

        List<int> primeNumbers = FindPrimeNumbers(startPosition, endPosition);
        for (int i = 0; i < primeNumbers.Count; i++)
        {
            if (i != primeNumbers.Count - 1)
            {
                Console.Write("{0}, ", primeNumbers[i]);
            }
            else
            {
                Console.WriteLine("{0}", primeNumbers[i]);
            }
        }
    }

    private static List<int> FindPrimeNumbers(int startPosition, int endPosition)
    {
        List<int> primeNumbers = new List<int>();
        for (int number = startPosition; number <= endPosition; number++)
        {
            if (isPrime(number))
            {
                primeNumbers.Add(number);
            }
        }
        return primeNumbers;
    }

    private static bool isPrime(int number)
    {
        if (number == 0 || number == 1)
        {
            return false;
        }
        else if (number > 2)
        {
            for (int i = 2; i * i <= number ; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
        }
        return true;
    }
}

