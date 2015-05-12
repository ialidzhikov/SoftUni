using System;
class FirstLargerThanNeighbours
{
    static void Main()
    {
        string inputLine = Console.ReadLine();

        string[] numbersAsStrings = inputLine.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[numbersAsStrings.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(numbersAsStrings[i]);
        }

        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(numbers));
    }

    private static int GetIndexOfFirstElementLargerThanNeighbours(int[] numbers)
    {
        int indexOfFirstElementLargerThanNeighbours = -1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsLargerThanNeighbours(numbers, i))
            {
                indexOfFirstElementLargerThanNeighbours = i;
                break;
            }
        }
        return indexOfFirstElementLargerThanNeighbours;
    }

    private static bool IsLargerThanNeighbours(int[] numbers, int currentIndex)
    {
        if (currentIndex == 0)
        {
            if (numbers[currentIndex] > numbers[currentIndex + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (currentIndex == numbers.Length - 1)
        {
            if (numbers[currentIndex] > numbers[currentIndex - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (numbers[currentIndex] > numbers[currentIndex - 1] && numbers[currentIndex] > numbers[currentIndex + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

