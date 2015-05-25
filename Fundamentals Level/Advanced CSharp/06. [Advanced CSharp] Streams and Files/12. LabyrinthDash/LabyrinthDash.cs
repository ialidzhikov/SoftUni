using System;
using System.Linq;
using System.Text;

class LabyrinthDash
{

    static void Main()
    {
        int labyrinthRows = int.Parse(Console.ReadLine());
        
        string[] labyrinth = new string[labyrinthRows];
        for (int row = 0; row < labyrinthRows; row++)
        {
            labyrinth[row] = Console.ReadLine();
        }

        char[] wallSymbols = { '_', '|' };
        char[] obstacleSymbols = {'@', '#', '*'};
        char newLifeSymbol = '$';

        int currentRow = 0;
        int currentCol = 0;
        int movesCount = 0;
        int livesLeft = 3;
        bool bumpedWall = false;

        string moves = Console.ReadLine();
        foreach (char direction in moves)
        {
            bumpedWall = false;
            if (direction == 'v')
            {
                if (currentRow + 1 < labyrinth.Length && wallSymbols.Contains(labyrinth[currentRow + 1][currentCol]))
                {
                    Console.WriteLine("Bumped a wall.");
                    bumpedWall = true;
                }
                else
                {
                    currentRow++;
                }
            }    
            else if (direction == '^')
            {
                if (currentRow - 1 >= 0 && wallSymbols.Contains(labyrinth[currentRow - 1][currentCol]))
                {
                    Console.WriteLine("Bumped a wall.");
                    bumpedWall = true;
                }
                else
                {
                    currentRow--;
                }
            }
            else if (direction == '>')
            {
                if (currentCol + 1 < labyrinth[currentRow].Length &&
                    wallSymbols.Contains(labyrinth[currentRow][currentCol + 1]))
                {
                    Console.WriteLine("Bumped a wall.");
                    bumpedWall = true;
                }
                else
                {
                    currentCol++;
                }
            }
            else if (direction == '<')
            {
                if (currentCol - 1 >= 0 && wallSymbols.Contains(labyrinth[currentRow][currentCol - 1]))
                {
                    Console.WriteLine("Bumped a wall.");
                    bumpedWall = true;
                }
                else
                {
                    currentCol--;
                }
            }

            if ((currentRow < 0 || currentRow >= labyrinth.Length) || (currentCol < 0 || currentCol >= labyrinth[currentRow].Length)
                || labyrinth[currentRow][currentCol] == ' ')
            {
                movesCount++;
                Console.WriteLine("Fell off a cliff! Game Over!");
                break;
            }
            else if (obstacleSymbols.Contains(labyrinth[currentRow][currentCol]))
            {
                movesCount++;
                livesLeft--;
                Console.WriteLine("Ouch! That hurt! Lives left: {0}", livesLeft);
                if (livesLeft <= 0)
                {
                    Console.WriteLine("No lives left! Game Over!");
                    break;
                }
            }
            else if (labyrinth[currentRow][currentCol] == '.' && !bumpedWall)
            {
                movesCount++;
                Console.WriteLine("Made a move!");
            }
            else if (newLifeSymbol == labyrinth[currentRow][currentCol])
            {
                livesLeft++;
                StringBuilder editedRow = new StringBuilder(labyrinth[currentRow]);
                editedRow[currentCol] = '.';
                labyrinth[currentRow] = editedRow.ToString();
                Console.WriteLine("Awesome! Lives left: {0}", livesLeft);
                movesCount++;
            }
        }
        Console.WriteLine("Total moves made: {0}", movesCount);

    }
}

