using System;
class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int fibonacciNumber = FindFibonacciNumber(n);
        Console.WriteLine(fibonacciNumber);
    }

    private static int FindFibonacciNumber(int n)
    {
        int currentNumber = 0;
        if (n == 0 || n == 1)
        {
            currentNumber = 1;
        }
        else if (n > 1)
        {
            int firstFibonacciNUmber = 1;
            int secondFibonacciNumber = 1;
            for (int i = 1; i < n; i++)
            {
                currentNumber = firstFibonacciNUmber + secondFibonacciNumber;

                firstFibonacciNUmber = secondFibonacciNumber;
                secondFibonacciNumber = currentNumber;
            }
        }

        return currentNumber;
    }
}

