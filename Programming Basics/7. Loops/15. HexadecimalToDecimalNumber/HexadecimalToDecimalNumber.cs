using System;
class HexadecimalToDecimalNumber
{
    static void Main()
    {
        string hexNumber = Console.ReadLine();

        int power = hexNumber.Length - 1;
        int currentNumber = 0;
        ulong decimalNumber = 0;
        foreach (var symbol in hexNumber)
        {
            if (Char.IsDigit(symbol))
            {
                currentNumber = int.Parse(symbol.ToString());
            }
            else if (Char.IsLetter(symbol))
            {
                switch (symbol)
                {
                    case 'A': currentNumber = 10; break;
                    case 'B': currentNumber = 11; break;
                    case 'C': currentNumber = 12; break;
                    case 'D': currentNumber = 13; break;
                    case 'E': currentNumber = 14; break;
                    case 'F': currentNumber = 15; break;
                    default: Console.WriteLine("Error");
                        break;
                }
            }
            decimalNumber += (ulong)currentNumber * (ulong)Math.Pow(16, power);
            power--;
        }
        Console.WriteLine(decimalNumber);
    }
}

