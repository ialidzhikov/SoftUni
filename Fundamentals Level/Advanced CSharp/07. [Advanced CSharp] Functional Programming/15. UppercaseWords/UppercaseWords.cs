using System;
using System.Text;
using System.Text.RegularExpressions;

class UppercaseWords
{
    private const string patternToExtractWords = @"[^a-zA-Z]";
    private const string patternToUppercase = @"^[A-Z]+$";
    static void Main()
    {
        string inputLine = Console.ReadLine();

        int startIndex = 0;
        StringBuilder outputLine = new StringBuilder(inputLine);
        StringBuilder outupText = new StringBuilder();
        while (inputLine != "END")
        {
            startIndex = -1;
            string[] words = Regex.Split(inputLine, patternToExtractWords, RegexOptions.Singleline);
            foreach (string word in words)
            {
                if (Regex.IsMatch(word, patternToUppercase, RegexOptions.Singleline))
                {
                    string reversedWord = ReverseWord(word);
                    startIndex = outputLine.ToString().IndexOf(word, startIndex + 1);
                    if (reversedWord == word)
                    {
                        string doubledWord = DoubleChars(word);
                        outputLine.Replace(word, doubledWord, startIndex, word.Length);
                        startIndex += doubledWord.Length;
                    }
                    else
                    {
                        outputLine.Replace(word, reversedWord, startIndex, word.Length);
                    }
                }
                else
                {
                    startIndex += word.Length;
                }
            }

            outupText.Append(outputLine);
            outupText.Append(Environment.NewLine);

            inputLine = Console.ReadLine();
            outputLine = new StringBuilder(inputLine);
        }

        Console.WriteLine(outupText);
    }

    private static string DoubleChars(string word)
    {
        StringBuilder doubledChars = new StringBuilder(word.Length * 2);
        for (int i = 0; i < word.Length; i++)
        {
            doubledChars.AppendFormat("{0}{0}", word[i]);
        }
        return doubledChars.ToString();
    }

    private static string ReverseWord(string word)
    {
        StringBuilder reversedWord = new StringBuilder(word.Length);
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord.Append(word[i]);
        }
        return reversedWord.ToString();
    }
}

