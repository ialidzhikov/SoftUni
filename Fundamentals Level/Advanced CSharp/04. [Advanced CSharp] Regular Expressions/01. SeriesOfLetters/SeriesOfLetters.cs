using System;
using System.Text;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    static void Main()
    {
        string stringToReplace = Console.ReadLine();

        string pattern = @"(([a-zA-z])\2*(?!\2))";
        MatchCollection matches = Regex.Matches(stringToReplace, pattern, RegexOptions.None);

        StringBuilder replacedString = new StringBuilder(matches.Count);
        foreach (Match match in matches)
        {
            replacedString.Append(match.Groups[2]);
        }

        Console.WriteLine(replacedString);
    }
}

