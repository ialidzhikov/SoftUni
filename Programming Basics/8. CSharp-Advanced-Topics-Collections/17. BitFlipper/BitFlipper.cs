using System;
using System.Text;

class BitFlipper
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());

        string binary = ConvertToBinary(number).PadLeft(64, '0');
        StringBuilder newBinary = new StringBuilder(binary);
        for (int i = 0; i < newBinary.Length - 2; i++)
        {
            if (newBinary[i] == newBinary[i + 1] && newBinary[i + 1] == newBinary[i + 2])
            {
                if (newBinary[i] == '0')
                {
                    newBinary[i] = '1';
                    newBinary[i + 1] = '1';
                    newBinary[i + 2] = '1';
                }
                else
                {
                    newBinary[i] = '0';
                    newBinary[i + 1] = '0';
                    newBinary[i + 2] = '0';
                }
                i += 2;
            }
        }

        Console.WriteLine(Convert.ToUInt64(newBinary.ToString(), 2));
    }

    private static string ConvertToBinary(ulong number)
    {
        string binary = "";
        while (number > 0)
        {
            binary = (number % 2) + binary;
            number /= 2;
        }
        return binary;
    }
}

