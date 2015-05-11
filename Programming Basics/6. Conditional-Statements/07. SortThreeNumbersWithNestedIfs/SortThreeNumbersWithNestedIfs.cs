using System;
class SortThreeNumbersWithNestedIfs
{
    static void Main()
    {
        double firstValue = double.Parse(Console.ReadLine());
        double secondValue = double.Parse(Console.ReadLine());
        double thirdValue = double.Parse(Console.ReadLine());

        double min = 0;
        double middle = 0;
        double max = 0;

        if (firstValue >= secondValue)
        {
            if (firstValue >= thirdValue)
            {
                max = firstValue;
                if (secondValue >= thirdValue)
                {
                    middle = secondValue;
                    min = thirdValue;
                }
                else
                {
                    middle = thirdValue; 
                    min = secondValue;
                }
            }
            else
            {
                max = thirdValue;
                middle = firstValue;
                min = secondValue;
            }
        }
        else
        {
            if (secondValue >= thirdValue)
            {
                max = secondValue;
                if (firstValue >= thirdValue)
                {
                    middle = firstValue;
                    min = thirdValue;
                }
                else
                {
                    middle = thirdValue;
                    min = firstValue;
                }
            }
            else
            {
                max = thirdValue;
                middle = secondValue;
                min = firstValue;
            }
        }

        Console.WriteLine("{0} {1} {2}", max, middle, min);
    }
}

