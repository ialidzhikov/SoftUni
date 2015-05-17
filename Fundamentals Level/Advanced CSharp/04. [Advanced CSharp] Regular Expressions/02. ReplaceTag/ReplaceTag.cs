using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceTag
{
    static void Main()
    {
        string htmlDocumnet = Console.ReadLine();

        string pattern = @"<a href=(?<link>\b[^>]+)>(?<text>[^<]*(?:(?!<\/a)<[^<]*)*)<\/a>";
        string replacedTag = Regex.Replace(htmlDocumnet, pattern, "[URL href=${link}]${text}[/URL]");
        
        Console.WriteLine(replacedTag);
    }
}

