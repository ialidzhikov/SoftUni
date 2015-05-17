using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class UseYourChainsBuddy
{
    static void Main()
    {
        Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));

        string htmlDocument = Console.ReadLine();

        string patternToExtract = @"<p>\s*(?<contents>.+?)\s*<\/p>";
        MatchCollection matches = Regex.Matches(htmlDocument, patternToExtract, RegexOptions.IgnorePatternWhitespace);

        foreach (Match match in matches)
        {
            string currentMatchValue = Regex.Replace(match.Groups["contents"].Value, @"[^a-z0-9]", " ");
            StringBuilder decryptedMessage = new StringBuilder(currentMatchValue.Length);
            foreach (char symbol in currentMatchValue)
            {
                if (Char.IsLetter(symbol))
                {
                    if (symbol < 'n')
                    {
                        decryptedMessage.Append((char)(symbol + 13));
                    }
                    else
                    {
                        decryptedMessage.Append((char)(symbol - 13));
                    }
                }
                else
                {
                    decryptedMessage.Append(symbol);
                }
            }
            Console.Write(Regex.Replace(decryptedMessage.ToString(), @"\s{2,}", @" "));
        }
        Console.WriteLine();
    }
}

