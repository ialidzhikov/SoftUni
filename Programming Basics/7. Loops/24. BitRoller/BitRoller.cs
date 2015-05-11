using System;
using System.Text;
class BitRoller
{
    const int SIZE = 19;
    static void Main()
    {
        int decimalNumber = int.Parse(Console.ReadLine());
        int frozenBit = int.Parse(Console.ReadLine());
        int rolls = int.Parse(Console.ReadLine());

        int frozenValue = (decimalNumber & (1 << frozenBit)) >> frozenBit; 

        string binaryNumber = Convert.ToString(decimalNumber, 2);
        string binaryWithZeroes = binaryNumber.PadLeft(19, '0');
        StringBuilder binary = new StringBuilder();
        for (int i = 0; i < SIZE; i++)
        {
            if (i != SIZE - frozenBit - 1)
            {
                binary.Append(binaryWithZeroes[i]);
            }
        }

        char firstChar = '\0';
        for (int i = 0; i < rolls; i++)
		{
            firstChar = binary[17];
            binary.Remove(17, 1);
            binary.Insert(0, firstChar);
		}

        binary.Insert(SIZE - frozenBit - 1, frozenValue);
        int newNumber = Convert.ToInt32(binary.ToString(), 2);
        Console.WriteLine(newNumber);
    }
}

