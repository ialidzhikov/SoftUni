using System;
using System.Text;
class DecimalToHexadecimalNumber
{
    static void Main()
    {
        ulong decimalNumber = ulong.Parse(Console.ReadLine());

        ulong remainder = 0;
        StringBuilder hexNumber = new StringBuilder();
        while (decimalNumber != 0)
        {
            remainder = decimalNumber % 16;
            switch (remainder)
            {
                case 10: hexNumber.Append('A'); break;
                case 11: hexNumber.Append('B'); break;
                case 12: hexNumber.Append('C'); break;
                case 13: hexNumber.Append('D'); break;
                case 14: hexNumber.Append('E'); break;
                case 15: hexNumber.Append('F'); break;
                default: hexNumber.Append(remainder);
                    break;
            }
            decimalNumber /= 16;
        }
        Console.WriteLine(ReverseString(hexNumber));
    }

    private static string ReverseString(StringBuilder hexNumber)
    {
        char[] charArray = hexNumber.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

