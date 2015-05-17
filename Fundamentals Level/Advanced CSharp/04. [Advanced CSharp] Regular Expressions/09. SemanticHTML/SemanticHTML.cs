using System;
using System.Text;
using System.Text.RegularExpressions;

class SemanticHTML
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        string patternToExtractStartTag =
            @"
                <div
                    \s*(?<otherTagsOne>[\s]{1}.*(?=\sid|\sclass))*?\s*?
                    (?:id\s*?|class\s*?)=\s*?
                    ""(?<semanticTag>main|header|nav|article|section|aside|footer)""
                    \s*(?<otherTagsTwo>[\s]{1}.*?)*?\s*?
                >
            ";
        string patternToExtractEndTag =
            @"
                <\/div>
                    \s*
                    <\s*!--\s*
                    (?<semanticTag>main|header|nav|article|section|aside|footer)
                    \s*--\s*
                >
            ";
        StringBuilder semanticHTMLCode = new StringBuilder();
        while (inputLine != "END")
        {
            if (Regex.IsMatch(inputLine, patternToExtractStartTag, RegexOptions.IgnorePatternWhitespace))
            {
                semanticHTMLCode.Append(Regex.Replace(inputLine, patternToExtractStartTag,
                    @"<${semanticTag}${otherTagsOne}${otherTagsTwo}>", RegexOptions.IgnorePatternWhitespace));
            }
            else if (Regex.IsMatch(inputLine, patternToExtractEndTag, RegexOptions.IgnorePatternWhitespace))
            {
                semanticHTMLCode.Append(
                    Regex.Replace(inputLine, patternToExtractEndTag, @"</${semanticTag}>", RegexOptions.IgnorePatternWhitespace));
            }
            else
            {
                semanticHTMLCode.Append(inputLine);
            }
            semanticHTMLCode.Append(Environment.NewLine);

            inputLine = Console.ReadLine();
        }

        Console.WriteLine(semanticHTMLCode);
    }
}

