using System;
class MultiplicationSign
{
    static void Main()
    {
        double firstValue = double.Parse(Console.ReadLine());
        double secondValue = double.Parse(Console.ReadLine());
        double thirdValue = double.Parse(Console.ReadLine());

        char sign = '0';
        if (FindPositivesCount(firstValue, secondValue, thirdValue) != -1)
        {
            if (FindPositivesCount(firstValue, secondValue, thirdValue) == 1 ||
                FindPositivesCount(firstValue, secondValue, thirdValue) == 3)
            {
                sign = '+';
            }
            else
            {
                sign = '-';
            }
        }

        Console.WriteLine(sign);
    }

    private static int FindPositivesCount(double firstValue, double secondValue, double thirdValue)
    {
        int count = 0;
        if (firstValue == 0 || secondValue == 0 || thirdValue == 0)
        {
            count = -1;
        }
        else
        {
            if (firstValue > 0)
            {
                count++;
            }
            if (secondValue > 0)
            {
                count++;
            }
            if (thirdValue > 0)
            {
                count++;
            }
        }
        return count;
    }
}

