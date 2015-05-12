using System;
class CountSubstringOccurrences
{
    static void Main()
    {
        string text = Console.ReadLine();
        string searchString = Console.ReadLine();

        int occurrencesCount = 0;
        int startIndex = text.IndexOf(searchString, 0, StringComparison.InvariantCultureIgnoreCase); ;
        while (startIndex != -1)
        {
            occurrencesCount++;
            startIndex = text.IndexOf(searchString, startIndex + 1, StringComparison.InvariantCultureIgnoreCase);
        } 

        Console.WriteLine(occurrencesCount);
    }
}

