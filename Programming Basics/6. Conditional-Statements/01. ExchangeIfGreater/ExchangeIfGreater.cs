using System;
class ExchangeIfGreater
{
    static void Main()
    {
        double firstValue = double.Parse(Console.ReadLine());
        double secondValue = double.Parse(Console.ReadLine());

        if (firstValue > secondValue)
        {
            firstValue = firstValue + secondValue;
            secondValue = firstValue - secondValue;
            firstValue = firstValue - secondValue;
        }

        Console.WriteLine("{0} {1}", firstValue, secondValue);
    }
}

