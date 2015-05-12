using System;
using System.Text;

class TextFilter
{
    static void Main()
    {
        string[] banList = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();

        StringBuilder textAsStringBuilder = new StringBuilder(text);
        foreach (string bannedWord in banList)
        {
            textAsStringBuilder.Replace(bannedWord, new string('*', bannedWord.Length));
        }

        Console.WriteLine(textAsStringBuilder);
    }
}

