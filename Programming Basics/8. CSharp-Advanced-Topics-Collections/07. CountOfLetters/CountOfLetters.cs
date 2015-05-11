using System;
class CountOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();

        string[] letters = input.Split(' ');

        int[] alphabet = new int[26];
        for (int i = 0; i < letters.Length; i++)
        {
            alphabet[Char.Parse(letters[i]) - 'a']++; 
        }

        for (int i = 0; i < alphabet.Length; i++)
        {
            if (alphabet[i] != 0)
            {
                Console.WriteLine("{0} -> {1}", (char)('a' + i), alphabet[i]);
            }
        }
    }
}

