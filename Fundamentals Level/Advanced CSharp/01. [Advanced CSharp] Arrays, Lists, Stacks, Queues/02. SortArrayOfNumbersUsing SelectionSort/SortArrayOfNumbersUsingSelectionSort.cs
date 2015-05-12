using System;
class SortArrayOfNumbersUsingSelectionSort
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

        SelectionSort(numbers);
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

    private static void SelectionSort(int[] numbers)
    {
        int minIndex = 0;
        int temp = 0;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            minIndex = i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[minIndex])
                {
                    minIndex = j;
                }
            }
            if (i != minIndex)
            {
                temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
            }
        }
    }
}

