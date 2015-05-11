using System;
class OddAndEvenProduct
{
    static char[] separators = { ' ' };
    static void Main()
    {
        string input = Console.ReadLine();
        string[] tokens = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        int[] sequence = new int[tokens.Length];
        for (int i = 0; i < sequence.Length; i++)
        {
            sequence[i] = int.Parse(tokens[i]);
        }

        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < sequence.Length; i++)
        {
            if ((i + 1) % 2 == 0)
            {
                evenProduct *= sequence[i];
            }
            else
            {
                oddProduct *= sequence[i];
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }
    }
}

