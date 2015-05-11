using System;
class QuotesInStrings
{
    static void Main()
    {
        string firstVariant = "The \"use\" of quotations causes difficulties.";
        string secondVariant = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(firstVariant);
        Console.WriteLine(secondVariant);

    }
}
