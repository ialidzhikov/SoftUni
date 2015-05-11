using System;
using System.Text;
class BitKiller
{
    const int BYTE_LENGHT = 8;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int count = 0;
        int index = 0;
        string binary = "";
        StringBuilder newBinary = new StringBuilder(BYTE_LENGHT * n);
        for (int i = 0; i < n; i++)
        {
            binary = Convert.ToString(numbers[i], 2);
            binary = binary.PadLeft(8, '0');
            for (int j = 0; j < BYTE_LENGHT; j++)
            {
                if (index == 0 || (index % step != 1 && step != 1))
                {
                    newBinary.Append(binary[j]);
                    count++;
                }
                if (count % 8 == 0 && count != 0)
                {
                    newBinary.Append(' ');
                }
                index++;
            }
        }
        int missingZeros = FindMissingZeros(count);
        newBinary = AddMissingZeros(newBinary, missingZeros);

        string newBinaryString = newBinary.ToString();
        char[] separators = { ' ' };
        string[] tokens = newBinaryString.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < tokens.Length; i++)
        {
            Console.WriteLine(Convert.ToInt32(tokens[i], 2));
        }
    }

    private static int FindMissingZeros(int count)
    {
        while (true)
        {
            count -= BYTE_LENGHT;
            if (count < 0)
            {
                return Math.Abs(count);
            }
        }
    }

    private static StringBuilder AddMissingZeros(StringBuilder newBinary, int missingZeros)
    {
        if (missingZeros == BYTE_LENGHT)
        {
            return newBinary;
        }
        else
        {
            for (int i = 0; i < missingZeros; i++)
            {
                newBinary.Append('0');
            }
        }
        return newBinary;
    }
}

