using System;
class SortingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        SortNumbers(numbers);
        PrintNumbers(numbers);
    }

    private static void PrintNumbers(int[] numbers)
    {
        Console.WriteLine();
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    private static void SortNumbers(int[] numbers)
    {
        int temp = 0;
        int minIndex = 0;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            minIndex = i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[minIndex] > numbers[j])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
            }
        }
    }
}

