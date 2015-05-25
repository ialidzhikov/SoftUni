using System;
using System.IO;
using System.Text;

class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader("OddLines.cs", Encoding.GetEncoding("windows-1251"));
        using (reader)
        {
            StreamWriter writer = new StreamWriter("AddedLineNumbers.cs", false, Encoding.GetEncoding("windows-1251"), 4096);
            using (writer)
            {
                int currentLineNumber = 1;
                string currentLineContents = reader.ReadLine();
                while (currentLineContents != null)
                {
                    writer.WriteLine("{0,5}: {1}", currentLineNumber, currentLineContents);
                    
                    currentLineContents = reader.ReadLine();
                    currentLineNumber++;
                }
            }
        }
    }
}

