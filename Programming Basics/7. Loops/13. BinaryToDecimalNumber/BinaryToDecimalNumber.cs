using System;
using System.Numerics;
class BinaryToDecimalNumber
{
    static void Main()
    {
        string input = Console.ReadLine();

        BigInteger binaryNumber = BigInteger.Parse(input);
        long decimalNumber = 0;
        for (int i = 0; binaryNumber != 0; i++)
        {
            if (binaryNumber % 10 == 1)
            {
                decimalNumber += (int)Math.Pow(2, i);
            }
            binaryNumber /= 10;
        }

        Console.WriteLine(decimalNumber);
    }
}

