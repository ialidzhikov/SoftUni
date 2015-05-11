using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        char symbol = '\u00A9';
        char space = ' ';
        int size = 7;

        //First line
        string firstLineSpaces = new string(space, 3);
        Console.WriteLine("{0}{1}{0}", firstLineSpaces, symbol);

        //Body
        for (int i = 1, j = 0; i < size / 2 + j; i += 2, j++)
        {
            string middleSpaces = new string(space, i);
            string forwardSpaces = new string(space, (size / 2) - i + j);

            Console.WriteLine("{0}{1}{2}{1}{0}", forwardSpaces, symbol, middleSpaces);
        }

        //Last Line
        Console.WriteLine("{1}{0}{1}{0}{1}{0}{1}", space, symbol);
    }
}

