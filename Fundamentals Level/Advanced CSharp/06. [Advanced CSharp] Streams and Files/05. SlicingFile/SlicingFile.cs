using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class SlicingFile
{
    private const int BufferSize = 1024*4;
    static void Main()
    {
        int parts = int.Parse("parts = 5".Split(new char[] {'='}, StringSplitOptions.RemoveEmptyEntries)[1]);
        string sourceFile = "trash.hs";

        string patternToExtractExtention = @".*(?<extention>\.[^\.]+)";
        string extention =
            (Regex.Match(sourceFile, patternToExtractExtention, RegexOptions.CultureInvariant).Groups["extention"]).ToString();

        Slice(sourceFile, "", parts, extention);
        List<string> files = new List<string>();
        for (int i = 0; i < parts; i++)
        {
            files.Add(String.Format("Part-{0}{1}", i, extention));
        }
        Assemble(files, "", extention);
    }

    private static void Assemble(List<string> files, string destinationDirectory, string extention)
    {
        FileStream assembledFileWriter = new FileStream("assembledFile" + extention, FileMode.CreateNew, FileAccess.Write);
        using (assembledFileWriter)
        {
            byte[] buffer = new byte[BufferSize];
            foreach (string file in files)
            {
                FileStream fileReader = new FileStream(file, FileMode.Open, FileAccess.Read);
                using (fileReader)
                {
                    int readBytes = fileReader.Read(buffer, 0, BufferSize);
                    while (readBytes > 0)
                    {
                        assembledFileWriter.Write(buffer, 0, readBytes);

                        readBytes = fileReader.Read(buffer, 0, BufferSize);
                    }
                }
            }
        }
    }

    private static void Slice(string sourceFile, string destinationDirectory, int parts, string extention)
    {
        FileStream sourceFileReader = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
        using (sourceFileReader)
        {
            decimal bytesParPart = (decimal)sourceFileReader.Length/parts;
            int currentPartIndex = 0;
            int readBytes = 0;
            byte[] buffer = new byte[BufferSize];
            int remainder = 0;
            while (currentPartIndex < parts)
            {
                FileStream currentPartStream = new FileStream(String.Format("Part-{0}" + extention, currentPartIndex), FileMode.Create, FileAccess.Write);
                using (currentPartStream)
                {
                    if (remainder != 0)
                    {
                        currentPartStream.Write(buffer, remainder, BufferSize - remainder);
                    }
                    decimal bytesToWrite = bytesParPart;
                    while (bytesToWrite > 0)
                    {
                        readBytes = sourceFileReader.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            remainder = 0;
                            break;
                        }

                        if (readBytes < BufferSize)
                        {
                            currentPartStream.Write(buffer, 0, readBytes);
                            remainder = readBytes;
                        }
                        else
                        {
                            currentPartStream.Write(buffer, 0, BufferSize);
                        };
                        bytesToWrite -= readBytes;
                    }
                }
                currentPartIndex++;
            }
        }
    }
}

