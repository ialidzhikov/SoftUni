using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string stringToReverse = Console.ReadLine();

        string reversedString = StringReverse(stringToReverse);
        Console.WriteLine(reversedString);
    }

    private static string StringReverse(string stringToReverse)
    {
        StringBuilder reversedString = new StringBuilder(stringToReverse.Length);
        for (int i = stringToReverse.Length - 1; i >= 0; i--)
        {
            reversedString.Append(stringToReverse[i]);
        }
        return reversedString.ToString();
    }
}

