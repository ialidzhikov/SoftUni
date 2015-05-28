using System;
class TextGravity
{
    static void Main()
    {
        int lineLength = 10;//int.Parse(Console.ReadLine());
        string text = "The Milky Way is the galaxy that contains our star system";//Console.ReadLine();

        int numberOfRows = 0;
        if (text.Length % lineLength != 0)
        {
            numberOfRows = (text.Length / lineLength) + 1;
        }
        else
        {
            numberOfRows = text.Length/lineLength;
        }
        char[,] table = new char[numberOfRows, lineLength];

        text = text.PadRight(numberOfRows*lineLength, ' ');
        int textIndex = 0;
        for (int row = 0; row < table.GetLength(0); row++)
        {
            for (int col = 0; col < table.GetLength(1); col++)
            {
                table[row, col] = text[textIndex];
                textIndex++;
            }
        }

        for (int col = table.GetLength(1) - 1; col >= 0; col--)
        {
            for (int row = table.GetLength(0) - 1; row >= 1; row--)
            {
                if (table[row, col] == ' ')
                {
                    for (int rowToSwap = row - 1; rowToSwap >= 0; rowToSwap--)
                    {
                        if (table[rowToSwap, col] != ' ')
                        {
                            table[row, col] = table[rowToSwap, col];
                            table[rowToSwap, col] = ' ';
                            break;
                        }
                    }
                }
            }
        }

        Console.WriteLine("<table>");
        for (int row = 0; row < table.GetLength(0); row++)
        {
            Console.WriteLine("<tr>");
            for (int col = 0; col < table.GetLength(1); col++)
            {
                Console.Write("<td>{0}</td> ", table[row, col]);
            }
            Console.WriteLine();
            Console.WriteLine("</tr>");
        }
        Console.WriteLine("</table>");
    }
}

