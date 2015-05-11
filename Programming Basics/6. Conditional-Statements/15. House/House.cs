using System;
class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintRoof(n);
        PrintBody(n);
    }

    private static void PrintBody(int n)
    {
        for (int i = 0; i < (n - 3) / 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 4), '*', new string('.', n - (n / 4) * 2 - 2));
        }

        Console.WriteLine("{0}{1}{0}", new string('.', n / 4), new string('*', n - (n / 4) * 2));
    }

    private static void PrintRoof(int n)
    {
        Console.WriteLine("{0}{1}{0}", new string('.', n / 2), '*');

        for (int i = 1; i <= n - 3; i += 2)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', (n - i - 2) / 2), '*', new string('.', i));
        }

        Console.WriteLine("{0}", new string('*', n));
    }
}

