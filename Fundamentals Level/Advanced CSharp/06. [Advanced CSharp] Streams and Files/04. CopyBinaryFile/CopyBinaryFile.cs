using System;
using System.IO;

class CopyBinaryFile
{
    static void Main()
    {
        FileStream source = new FileStream("Martin Garrix - Animals.mp3", FileMode.Open, FileAccess.Read);
        using (source)
        {
            FileStream destination = new FileStream("(copied)Martin Garrix - Animals.mp3", FileMode.Create, FileAccess.Write);
            using (destination)
            {
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int readBytes = source.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }
                    destination.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}

