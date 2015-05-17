using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ExtractHyperlinks
{
    static void Main()
    {
        List<string> htmlDocumentLinesList = new List<string>();
        
        StringBuilder htmlDocumentStringBuilder = new StringBuilder(); 
        string currentLine = Console.ReadLine();
        while (currentLine != "END")
        {
            htmlDocumentStringBuilder.Append(currentLine);

            currentLine = Console.ReadLine();
        }

        string patternToExtractHyperlinks = @"<a\s+(?:[^>]+\s+)?href\s*=\s*(?<link>'([^']*)'|""([^""]*)""|([^\s>]+))[^>]*>";
        MatchCollection matches = Regex.Matches(htmlDocumentStringBuilder.ToString(), patternToExtractHyperlinks,
            RegexOptions.IgnorePatternWhitespace);
        string currentHyperlink = String.Empty;
        foreach (Match match in matches)
        {
            currentHyperlink = match.Groups["link"].ToString();
            Console.WriteLine(currentHyperlink.Substring(1, currentHyperlink.Length - 2));
        }


    }
}

