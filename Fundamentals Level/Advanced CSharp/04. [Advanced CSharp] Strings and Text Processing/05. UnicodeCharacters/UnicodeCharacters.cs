using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string text = Console.ReadLine();

        StringBuilder unicodeSequence = new StringBuilder();
        foreach (char symbol in text)
        {
            unicodeSequence.AppendFormat(@"\u{0}", ((int) symbol).ToString("x4"));
        }

        Console.WriteLine(unicodeSequence);
    }
}

