using System;
using System.Text;
class ProgrammerDNA
{
    const int LINE_LENGTH = 7;
    static char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());

        int copy = n;
        bool flag = true;
        int charPos = FindCharPosition(letter);
        while (copy > 0)
        {
            for (int i = 0, j = 1; i < 4; i++, j += 2)
            {
                string sequence = GenerateSequence(j, charPos % letters.Length);
                string dots = new string('.', (LINE_LENGTH - sequence.Length) / 2);
                Console.WriteLine("{0}{1}{0}", dots, sequence);
                charPos += j;
                copy--;
                if (copy == 0)
                {
                    flag = false;
                    break;
                }
            }
            for (int i = 0, j = 5; i < 3 && flag; i++, j -= 2)
            {
                string sequence = GenerateSequence(j, charPos % letters.Length);
                string dots = new string('.', (LINE_LENGTH - sequence.Length) / 2);
                Console.WriteLine("{0}{1}{0}", dots, sequence);
                charPos += j;
                copy--;
                if (copy == 0)
                {
                    flag = false;
                    break;
                }
            }
        }
    }

    private static int FindCharPosition(char letter)
    {
        int charPos = -1;
        for (int i = 0; i < letters.Length; i++)
        {
            if (letter == letters[i])
            {
                charPos = i;
                break;
            }
        }
        return charPos;
    }

    private static string GenerateSequence(int length, int startPos)
    {
        StringBuilder sequence = new StringBuilder(length);
        for (int i = 0; i < length; i++)
        {
            sequence.Append(letters[startPos]);
            startPos++;
            if (startPos == letters.Length)
            {
                startPos = 0;
            }
        }
        return sequence.ToString();
    }
}

