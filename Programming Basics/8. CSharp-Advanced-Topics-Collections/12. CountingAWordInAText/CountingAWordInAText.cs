using System;
class CountingAWordInAText
{
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();

        int wordCount = 0;

        int index = 0;
        int startIndex = 0;
        while (true)
        {
            index = text.IndexOf(word, startIndex, StringComparison.OrdinalIgnoreCase);
            if (index == -1)
            {
                break;
            }
            else //if (index + word.Length < text.Length)
            {
                if (!((index + word.Length != text.Length && Char.IsLetterOrDigit(text[index + word.Length])) 
                    || (index != 0 && Char.IsLetterOrDigit(text[index - 1]))))
                {
                    wordCount++;
                }
            }
            startIndex = index + word.Length;
            if (startIndex >= text.Length)
            {
                break;
            }
        }

        Console.WriteLine(wordCount);
    }
}

