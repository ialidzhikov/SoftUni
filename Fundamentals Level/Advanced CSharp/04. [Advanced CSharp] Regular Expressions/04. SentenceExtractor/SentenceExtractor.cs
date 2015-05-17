using System;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main()
    {
        string keyword = Console.ReadLine();
        string text = Console.ReadLine();

        string pattern = String.Format(
            @"
                \b
                ([^\.\!?]+)?
                \b{0}\b
                ([^\.\!?]+)?
                [\.\!?]
            ", keyword);

        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnorePatternWhitespace);
        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }

    }
}

