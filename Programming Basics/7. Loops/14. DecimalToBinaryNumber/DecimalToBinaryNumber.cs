using System;
using System.Text;
class DecimalToBinaryNumber
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());

        StringBuilder binaryNumber = new StringBuilder();
        while (decimalNumber != 0)
        {
            binaryNumber.Append(decimalNumber % 2);
            decimalNumber /= 2;
        }

        Console.WriteLine(ReverseString(binaryNumber));
    }

    private static string ReverseString(StringBuilder binaryNumber)
    {
        char[] charArray = binaryNumber.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

