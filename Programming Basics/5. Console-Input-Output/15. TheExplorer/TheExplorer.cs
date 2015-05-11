using System;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintFirstLine(n);
        PrintUpperBody(n);
        PrintDownerBody(n);
        PrintFirstLine(n);
    }

    private static void PrintDownerBody(int n)
    {
        for (int i = (n - 2) - (n / 2), k = 2; i >= 0; i--)
        {
            for (int j = 1; j <= n; j++)
            {
                if (n / 2 - i == j || n / 2 + i + k == j)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
        }
    }

    private static void PrintUpperBody(int n)
    {
        for (int i = 0, k = 2; i < n - (n / 2 + 1); i++, k += 2)
        {
            for (int j = 1; j <= n; j++)
            {
                if (n / 2 - i == j || (n / 2 + k - i == j))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine();
        }
    }

    private static void PrintFirstLine(int n)
    {
        for (int i = 0; i < n; i++)
        {
            if (i == n / 2)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write("-");
            }
        }
        Console.WriteLine();
    }
}

