using System;
using System.Text.RegularExpressions;
class ExtractURLsFromText
{
    static void Main()
    {
        string input = Console.ReadLine();
        
        string pattern = @"\b(?:https?://|www\.)\S+(?:\.([a-z]){2,3})\b";
        MatchCollection matches = Regex.Matches(input, pattern);
        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

