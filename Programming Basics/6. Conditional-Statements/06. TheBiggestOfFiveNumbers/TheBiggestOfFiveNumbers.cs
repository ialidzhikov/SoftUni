using System;
class TheBiggestOfFiveNumbers
{
    static void Main(string[] args)
    {
        double firstValue = double.Parse(Console.ReadLine());
        double secondValue = double.Parse(Console.ReadLine());
        double thirdValue = double.Parse(Console.ReadLine());
        double fourthValue = double.Parse(Console.ReadLine());
        double fifthValue = double.Parse(Console.ReadLine());

        double biggest = FindBiggest(firstValue, secondValue, thirdValue, fourthValue, fifthValue);
        Console.WriteLine(biggest);
    }

    private static double FindBiggest(double firstValue, double secondValue, double thirdValue, double fourthValue, double fifthValue)
    {
        double max = firstValue;
        if (secondValue > max)
        {
            max = secondValue;
        }
        if (thirdValue > max)
        {
            max = thirdValue;
        }
        if (fourthValue > max)
        {
            max = fourthValue;
        }
        if (fifthValue > max)
        {
            max = fifthValue;
        }

        return max;
    }
}

