using System;
class FibonacciNumbers
{
    static void Main()
    {
        int n = 10;

        int[] fibonacci = new int[10];
        fibonacci[0] = 0;
        fibonacci[1] = 1;

        for (int i = 2; i < n ; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", fibonacci[i]);
        }
        Console.WriteLine();
    }
}

