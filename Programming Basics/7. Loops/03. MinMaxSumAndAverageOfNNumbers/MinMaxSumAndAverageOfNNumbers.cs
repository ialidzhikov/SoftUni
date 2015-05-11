using System;
class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int min = FindMin(numbers);
        int max = FindMax(numbers);
        int sum = FindSum(numbers);
        double average = sum / (double)n;

        Console.WriteLine("{0}", min);
        Console.WriteLine("{0}", max);
        Console.WriteLine("{0}", sum);
        Console.WriteLine("{0:F2}", average);
    }

    private static int FindSum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    private static int FindMax(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }

    private static int FindMin(int[] numbers)
    {
        int min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }
}

