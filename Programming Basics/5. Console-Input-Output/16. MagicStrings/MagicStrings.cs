using System;

class MagicStrings
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        int[] array = { 1, 4, 5, 3 };

        int leftSum = 0;
        int rightSum = 0;
        int resultCounter = 0;

        for (int loopOne = 0; loopOne < 4; loopOne++)
        {
            for (int loopTwo = 0; loopTwo < 4; loopTwo++)
            {
                for (int loopThree = 0; loopThree < 4; loopThree++)
                {
                    for (int loopFour = 0; loopFour < 4; loopFour++)
                    {
                        leftSum = array[loopOne] + array[loopTwo] + array[loopThree] + array[loopFour];

                        for (int loopFive = 0; loopFive < 4; loopFive++)
                        {
                            for (int loopSix = 0; loopSix < 4; loopSix++)
                            {
                                for (int loopSeven = 0; loopSeven < 4; loopSeven++)
                                {
                                    for (int loopEight = 0; loopEight < 4; loopEight++)
                                    {
                                        rightSum = array[loopFive] + array[loopSix] + array[loopSeven] + array[loopEight];

                                        if (Math.Abs(leftSum - rightSum) == diff)
                                        {
                                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}",
                                                ReturnTheChar(loopOne), ReturnTheChar(loopTwo), ReturnTheChar(loopThree),
                                                ReturnTheChar(loopFour), ReturnTheChar(loopFive), ReturnTheChar(loopSix),
                                                ReturnTheChar(loopSeven), ReturnTheChar(loopEight));
                                            resultCounter++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (resultCounter == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static char ReturnTheChar(int number)
    {
        if (number == 0)
        {
            return 'k';
        }
        else if (number == 1)
        {
            return 'n';
        }
        else if (number == 2)
        {
            return 'p';
        }
        else
        {
            return 's';
        }
    }
}

