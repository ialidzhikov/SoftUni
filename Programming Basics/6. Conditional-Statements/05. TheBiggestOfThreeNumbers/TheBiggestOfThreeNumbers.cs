using System;
class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        double firstValue = double.Parse(Console.ReadLine());
        double secondValue = double.Parse(Console.ReadLine());
        double thirdValue = double.Parse(Console.ReadLine());

        double biggest = FindBiggestValue(firstValue, secondValue, thirdValue);
        Console.WriteLine(biggest);
    }

    private static double FindBiggestValue(double firstValue, double secondValue, double thirdValue)
    {
        if (firstValue >= secondValue)
        {
            if (firstValue >= thirdValue)
            {
                return firstValue;
            }
            else
            {
                return thirdValue;
            }
        }
        else
        {
            if (secondValue >= thirdValue)
            {
                return secondValue;
            }
            else
            {
                return thirdValue;
            }
        }
    }
}

