using System;
class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string firstLine = new string('*', n * 2);
        Console.WriteLine("{0}{1}{0}", firstLine, new string(' ', n));

        for (int i = 0; i < n - 2; i++)
        {
            string bodyLens = new string('/', (n * 2) - 2);
            string bodyLine = string.Format("{0}{1}{0}", "*", bodyLens);
            if ((n - 2) / 2 != i)
            {
                Console.WriteLine("{0}{1}{0}", bodyLine, new string(' ', n));
            }
            else
            {
                Console.WriteLine("{0}{1}{0}", bodyLine, new string('|', n));
            }
        }

        Console.WriteLine("{0}{1}{0}", firstLine, new string(' ', n));
    }
}

