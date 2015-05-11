using System;
class RandomizeNumbers
{
    static Random randomGenerator = new Random();
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }

        int temp = 0;
        for (int i = 0, j = 0; i < n; i++)
        {
            j = randomGenerator.Next(0, n);
            temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }

        foreach (var item in numbers)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}

