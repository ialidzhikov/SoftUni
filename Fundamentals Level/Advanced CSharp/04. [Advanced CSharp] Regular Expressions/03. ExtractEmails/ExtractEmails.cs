using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string text = Console.ReadLine();

        string pattern = 
                @"
                    (?<=\s)
                    (
                        [a-zA-Z0-9]
                        |((?<=[a-zA-Z0-9])\.(?=[a-zA-Z0-9]))
                        |((?<=[a-zA-Z0-9])-(?=[a-zA-Z0-9]))
                        |((?<=[a-zA-Z0-9])_(?=[a-zA-Z0-9]))
                    )+
                    @
                    (
                        [a-z]
                        |((?<=[a-z])-(?=[a-z]))
                    )+
                    \.
                    (
                        [a-z]
                        |(\.(?=[a-z]))
                    )+
                ";

        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnorePatternWhitespace);
        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

