using System;
class NumberAsWords
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int hundreds = number / 100;
        int tens = (number / 10) % 10;
        int ones = number % 10;

        if (number < 20)
        {
            switch (number)
            {
                case 0: Console.WriteLine("Zero"); break;
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                case 10: Console.WriteLine("Ten"); break;
                case 11: Console.WriteLine("Eleven"); break;
                case 12: Console.WriteLine("Twelve"); break;
                case 13: Console.WriteLine("Thirteen"); break;
                case 14: Console.WriteLine("Fourteen"); break;
                case 15: Console.WriteLine("Fifteen"); break;
                case 16: Console.WriteLine("Sixteen"); break;
                case 17: Console.WriteLine("Seventeen"); break;
                case 18: Console.WriteLine("Eighteen"); break;
                case 19: Console.WriteLine("Nineteen"); break;
                default: Console.WriteLine("Error");
                    break;
            }
        }
        else if (number < 100)
        {
            switch (tens)
            {
                case 2: Console.Write("Twenty"); break;
                case 3: Console.Write("Thirty"); break;
                case 4: Console.Write("Forty"); break;
                case 5: Console.Write("Fifty"); break;
                case 6: Console.Write("Sixty"); break;
                case 7: Console.Write("Seventy"); break;
                case 8: Console.Write("Eighty"); break;
                case 9: Console.Write("Ninety"); break;
                default: Console.WriteLine("Error");
                    break;
            }
            switch (ones)
            {
                case 1: Console.WriteLine(" one"); break;
                case 2: Console.WriteLine(" two"); break;
                case 3: Console.WriteLine(" three"); break;
                case 4: Console.WriteLine(" four"); break;
                case 5: Console.WriteLine(" five"); break;
                case 6: Console.WriteLine(" six"); break;
                case 7: Console.WriteLine(" seven"); break;
                case 8: Console.WriteLine(" eight"); break;
                case 9: Console.WriteLine(" nine"); break;
                default: Console.WriteLine();
                    break;
            }
        }
        else
        {
            switch (hundreds)
            {
                case 1: Console.Write("One hundred"); break;
                case 2: Console.Write("Two hundred"); break;
                case 3: Console.Write("Three hundred"); break;
                case 4: Console.Write("Four hundred"); break;
                case 5: Console.Write("Five hundred"); break;
                case 6: Console.Write("Six hundred"); break;
                case 7: Console.Write("Seven hundred"); break;
                case 8: Console.Write("Eight hundred"); break;
                case 9: Console.Write("Nine hundred"); break;
                default: Console.WriteLine("Error");
                    break;
            }

            if (tens == 0)
            {
                switch (ones)
                {
                    case 1: Console.WriteLine(" and one"); break;
                    case 2: Console.WriteLine(" and two"); break;
                    case 3: Console.WriteLine(" and three"); break;
                    case 4: Console.WriteLine(" and four"); break;
                    case 5: Console.WriteLine(" and five"); break;
                    case 6: Console.WriteLine(" and six"); break;
                    case 7: Console.WriteLine(" and seven"); break;
                    case 8: Console.WriteLine(" and eight"); break;
                    case 9: Console.WriteLine(" and nine"); break;
                    default: Console.WriteLine();
                        break;
                }    
            }
            else if (tens == 1)
            {
                switch (ones)
                {
                    case 1: Console.WriteLine(" and eleven"); break;
                    case 2: Console.WriteLine(" and twelve"); break;
                    case 3: Console.WriteLine(" and thirteen"); break;
                    case 4: Console.WriteLine(" and fourteen"); break;
                    case 5: Console.WriteLine(" and fifteen"); break;
                    case 6: Console.WriteLine(" and sixteen"); break;
                    case 7: Console.WriteLine(" and seventeen"); break;
                    case 8: Console.WriteLine(" and eighteen"); break;
                    case 9: Console.WriteLine(" and nineteen"); break;
                    default: Console.WriteLine();
                        break;
                }
            }
            else 
            {
                switch (tens)
                {
                    case 2: Console.Write(" and twenty"); break;
                    case 3: Console.Write(" and thirty"); break;
                    case 4: Console.Write(" and forty"); break;
                    case 5: Console.Write(" and fifty"); break;
                    case 6: Console.Write(" and sixty"); break;
                    case 7: Console.Write(" and seventy"); break;
                    case 8: Console.Write(" and eighty"); break;
                    case 9: Console.Write(" and ninety"); break;
                    default: Console.WriteLine("Error");
                        break;
                }
                switch (ones)
                {
                    case 1: Console.WriteLine(" one"); break;
                    case 2: Console.WriteLine(" two"); break;
                    case 3: Console.WriteLine(" three"); break;
                    case 4: Console.WriteLine(" four"); break;
                    case 5: Console.WriteLine(" five"); break;
                    case 6: Console.WriteLine(" six"); break;
                    case 7: Console.WriteLine(" seven"); break;
                    case 8: Console.WriteLine(" eight"); break;
                    case 9: Console.WriteLine(" nine"); break;
                    default: Console.WriteLine();
                        break;
                }
            }
        }
    }
}

