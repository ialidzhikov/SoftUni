using System;
class NumberCalculations
{
    private static void Main()
    {
        string chosedType = Console.ReadLine();
        string inputLine = Console.ReadLine();

        string[] numbersAsStrings = inputLine.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
        if (chosedType.ToLower().Equals("int"))
        {
            int[] numbers = new int[numbersAsStrings.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!int.TryParse(numbersAsStrings[i], out numbers[i]))
                {
                    throw new InvalidOperationException("Cannot parse to int.");
                }
            }

            Console.WriteLine(GetMinimum(numbers));
            Console.WriteLine(GetMaximum(numbers));
            Console.WriteLine(GetAverage(numbers));
            Console.WriteLine(GetSum(numbers));
            Console.WriteLine(GetProduct(numbers));
        }
        else if (chosedType.ToLower().Equals("double"))
        {
            double[] numbers = new double[numbersAsStrings.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!double.TryParse(numbersAsStrings[i], out numbers[i]))
                {
                    throw new InvalidOperationException("Cannot parse to double.");
                }
            }

            Console.WriteLine(GetMinimum(numbers));
            Console.WriteLine(GetMaximum(numbers));
            Console.WriteLine(GetAverage(numbers));
            Console.WriteLine(GetSum(numbers));
            Console.WriteLine(GetProduct(numbers));
        }
    }

    private static double GetProduct(double[] numbers)
    {
        double product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }

    private static int GetProduct(int[] numbers)
    {
        int product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }

    private static double GetSum(double[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }

    private static int GetSum(int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    private static double GetAverage(double[] numbers)
    {
        return ((double)GetSum(numbers)) / numbers.Length;
    }

    private static double GetAverage(int[] numbers)
    {
        return ((double)GetSum(numbers)) / numbers.Length;
    }
    private static double GetMaximum(double[] numbers)
    {
        int maxIndex = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[maxIndex] < numbers[i])
            {
                maxIndex = i;
            }
        }
        return numbers[maxIndex];
    }

    private static int GetMaximum(int[] numbers)
    {
        int maxIndex = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[maxIndex] < numbers[i])
            {
                maxIndex = i;
            }
        }
        return numbers[maxIndex];
    }

    private static double GetMinimum(double[] numbers)
    {
        int minIndex = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[minIndex] > numbers[i])
            {
                minIndex = i;
            }
        }
        return numbers[minIndex];
    }

    private static int GetMinimum(int[] numbers)
    {
        int minIndex = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[minIndex] > numbers[i])
            {
                minIndex = i;
            }
        }
        return numbers[minIndex];
    }
}

