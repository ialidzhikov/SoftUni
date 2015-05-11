using System;
class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintUpperPart(n);
        PrintLowerPart(n);
    }

    private static void PrintLowerPart(int n)
    {
        int outsidePoints = 0;
        int insidePoints = 0;
        for (int i = 0; i < n - 2; i++)
        {
            outsidePoints = i + 1;
            insidePoints = (n * 2) - (outsidePoints * 2) - 3;
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', outsidePoints), '#', new string('.', insidePoints));
        }

        Console.WriteLine("{0}{1}{0}", new string('.', n - 1), '#');
    }

    private static void PrintUpperPart(int n)
    {
        Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('#', n));

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), '#', new string('.', n - 2));
        }

        Console.WriteLine("{0}{1}{0}", new string('#', (n / 2) + 1), new string('.', n - 2));
    }
}

