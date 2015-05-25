using System;
using System.IO;
using System.Text;

class Disk
{
    static void Main()
    {
        StreamReader reader = new StreamReader("01. OddLines.txt", Encoding.GetEncoding("windows-1251"));

        using (reader)
        {
            int currentLineNumber = 1;
            string currentLineContents = reader.ReadLine();
            while (!String.IsNullOrEmpty(currentLineContents))
            {
                if (currentLineNumber % 2 != 0)
                {
                    Console.WriteLine(currentLineContents);
                }
                currentLineContents = reader.ReadLine();
                currentLineNumber++;
            }
        }
    }
}

