using System;

class PrintADeckOfCards
{
    const int CARDS_LENGTH = 15;
    const int SUITS_LENGHT = 4;
    static void Main()
    {
        for (int i = 2; i < CARDS_LENGTH; i++)
        {
            for (int j = 1; j <= SUITS_LENGHT ; j++)
            {
                PrintCard(i);
                PrintSuit(j);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }

    private static void PrintSuit(int j)
    {
        switch (j)
        {
            case 1: Console.Write('\u2663'); break;
            case 2: Console.Write('\u2666'); break;
            case 3: Console.Write('\u2665'); break;
            case 4: Console.Write('\u2660'); break;
            default:
                break;
        }
    }

    private static void PrintCard(int i)
    {
        switch (i)
        {
            case 11: Console.Write("{0,2}", 'J'); break;
            case 12: Console.Write("{0,2}", 'Q'); break;
            case 13: Console.Write("{0,2}", 'K'); break;
            case 14: Console.Write("{0,2}", 'A'); break;
            default: Console.Write("{0,2}", i);
                break;
        }
    }
}

