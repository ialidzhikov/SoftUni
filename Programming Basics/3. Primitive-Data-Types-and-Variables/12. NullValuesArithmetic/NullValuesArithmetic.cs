using System;
class NullValuesArithmetic
{
    static void Main()
    {
        int? firstValue = null;
        double? secondValue = null;

        Console.WriteLine(firstValue);
        Console.WriteLine(secondValue);

        firstValue += 10;
        secondValue += 5.0;

        Console.WriteLine(firstValue);
        Console.WriteLine(secondValue);

        firstValue += null;
        secondValue += null;

        Console.WriteLine(firstValue);
        Console.WriteLine(secondValue);
    }
}

