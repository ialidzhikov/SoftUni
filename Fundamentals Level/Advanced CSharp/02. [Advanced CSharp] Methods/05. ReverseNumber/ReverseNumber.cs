using System;
class ReverseNumber
{
    static void Main()
    {
        double numberToReverse = double.Parse(Console.ReadLine());

        double reversedNumber = GetReversedNumber(numberToReverse);
        Console.WriteLine(reversedNumber);
    }

    private static double GetReversedNumber(double numberToReverse)
    {
        char[] reversedDoubleAsCharArray = numberToReverse.ToString().ToCharArray();
        Array.Reverse(reversedDoubleAsCharArray);
        string reversedDoubleAsString = new string(reversedDoubleAsCharArray);
        return double.Parse(reversedDoubleAsString);
    }
}

