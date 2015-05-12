using System;
class PythagoreanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        bool matchFound = false;
        for (int indexOne = 0; indexOne < n; indexOne++)
        {
            for (int indexTwo = 0; indexTwo < n; indexTwo++)
            {
                for (int indexThree = 0; indexThree < n; indexThree++)
                {
                    int a = numbers[indexOne];
                    int b = numbers[indexTwo];
                    int c = numbers[indexThree];

                    if (a <= b && (a * a) + (b * b) == (c * c))
                    {
                        Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", a, b, c);
                        matchFound = true;
                    }
                }
            }
        }
        if (!matchFound)
        {
            Console.WriteLine("No");
        }
    }
}

