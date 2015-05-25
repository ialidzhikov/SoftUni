    1: using System;
    2: using System.IO;
    3: using System.Text;
    4: 
    5: class Disk
    6: {
    7:     static void Main()
    8:     {
    9:         StreamReader reader = new StreamReader("01. OddLines.txt", Encoding.GetEncoding("windows-1251"));
   10: 
   11:         using (reader)
   12:         {
   13:             int currentLineNumber = 1;
   14:             string currentLineContents = reader.ReadLine();
   15:             while (!String.IsNullOrEmpty(currentLineContents))
   16:             {
   17:                 if (currentLineNumber % 2 != 0)
   18:                 {
   19:                     Console.WriteLine(currentLineContents);
   20:                 }
   21:                 currentLineContents = reader.ReadLine();
   22:                 currentLineNumber++;
   23:             }
   24:         }
   25:     }
   26: }
   27: 
