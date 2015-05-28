using System;
using System.Text;
using System.Text.RegularExpressions;

class LittleJohn
{
    private const string smallArrowPattern = @"(?:[^>]+?|^)>----->(?:[^>]+?|$)";
    private const string mediumArrowPattern = @"(?:[^>]+?|^)>>----->(?:[^>]+?|$)";
    private const string largeArrowPattern = @"(?:[^>]+?|^)>>>----->>(?:[^>]+?|$)";
    static void Main()
    {
        int smallArrowsCount = 0;
        int mediumArrowsCount = 0;
        int largeArrowsCount = 0;

        for (int i = 0; i < 4; i++)
        {
            string hay = Console.ReadLine();

            smallArrowsCount += Regex.Matches(hay, smallArrowPattern, RegexOptions.Singleline).Count;
            mediumArrowsCount += Regex.Matches(hay, mediumArrowPattern, RegexOptions.Singleline).Count;
            largeArrowsCount += Regex.Matches(hay, largeArrowPattern, RegexOptions.Singleline).Count;
        }

        Console.WriteLine(EncryptMessage(smallArrowsCount, mediumArrowsCount, largeArrowsCount));
    }

    private static int EncryptMessage(int smallArrowsCount, int mediumArrowsCount, int largeArrowsCount)
    {
        int arrowsDecimal =
            int.Parse(smallArrowsCount.ToString() + mediumArrowsCount.ToString() + largeArrowsCount.ToString());
        string arrowsBinary = Convert.ToString(arrowsDecimal, 2);
        arrowsBinary += ReverseString(arrowsBinary);
        return Convert.ToInt32(arrowsBinary, 2);
    }

    private static string ReverseString(string arrowsBinary)
    {
        StringBuilder reversedString = new StringBuilder(arrowsBinary.Length);
        for (int i = arrowsBinary.Length - 1; i >= 0; i--)
        {
            reversedString.Append(arrowsBinary[i]);
        }
        return reversedString.ToString();
    }
}

