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
        for (int i = 0; i < (n / 2) - 1; i++)
        {
            string outsideDashes = new string('-', i + 1);
            string middleDashes = new string('-', n - 4 - (i * 2));

            Console.WriteLine("{0}{1}{2}{1}{0}", outsideDashes, '*', middleDashes);
        }
    }

    private static void PrintUpperBody(int n)
    {
        for (int i = 0; i < n / 2; i++)
        {
            string outsideDashes = new string('-', (n / 2) - i - 1);
            string middleDashes = new string('-', (i * 2) + 1);

            Console.WriteLine("{0}{1}{2}{1}{0}", outsideDashes, '*', middleDashes);
        }
    }

    private static void PrintFirstLine(int n)
    {
        Console.WriteLine("{0}{1}{0}", new string('-', n / 2), '*');
    }
}

