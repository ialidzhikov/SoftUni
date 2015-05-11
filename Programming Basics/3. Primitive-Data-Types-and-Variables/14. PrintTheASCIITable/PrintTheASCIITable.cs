using System;
using System.Text;
class PrintTheASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        for (int i = 0; i < 256; i++)
        {
            string display = null;
            if (char.IsWhiteSpace((char)i))
            {
                switch ((char)i)
                {
                    case '\t': display = "\\t"; break;
                    case ' ': display = "space"; break;
                    case '\n': display = "\\n"; break;
                    case '\r': display = "\\r"; break;
                    case '\v': display = "\\v"; break;
                    case '\f': display = "\\f"; break;
                }
            }
            else if (char.IsControl((char)i))
            {
                display = "control";
            }
            else
            {
                display = ((char)i).ToString();
            }

            Console.WriteLine(display);
        }
    }
}

