using System;
using System.Collections.Concurrent;

class SortArrayOfNumbers
{
    static void Main()
    {
        string inputLine = Console.ReadLine();

        string[] numbersAsStrings = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[numbersAsStrings.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(numbersAsStrings[i]);
        }

        QuickSort(numbers, 0, numbers.Length);
        Print(numbers);
    }

    private static void Print(int[] numbers)
    {
        foreach (int number in numbers)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
    }

    private static void QuickSort(int[] numbers, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(numbers, left, right);

            QuickSort(numbers, left, pivot - 1);
            QuickSort(numbers, pivot, right);
        }
    }

    private static int Partition(int[] numbers, int left, int right)
    {
        int start = left;
        int pivot = numbers[start];
        left++;
        right--;

        while (true)
        {
            while (left <= right && numbers[left] <= pivot)
            {
                left++;
            }
            while (left <= right && numbers[right] > pivot)
            {
                right--;
            }

            if (left > right)
            {
                numbers[start] = numbers[left - 1];
                numbers[left - 1] = pivot;

                return left;
            }

            int temp = numbers[left];
            numbers[left] = numbers[right];
            numbers[right] = temp;
        }
    }
}

