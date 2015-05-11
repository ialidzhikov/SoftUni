using System;
class QuadraticEquation
{
    static void Main()
    {
        double firstCoef = double.Parse(Console.ReadLine());
        double secondCoef = double.Parse(Console.ReadLine());
        double thirdCoef = double.Parse(Console.ReadLine());

        FindRoots(firstCoef, secondCoef, thirdCoef);
    }

    private static void FindRoots(double firstCoef, double secondCoef, double thirdCoef)
    {
        double[] roots = new double[2];
        if (firstCoef == 0)
        {
            roots[0] = -thirdCoef / secondCoef;
        }
        else if (secondCoef == 0)
        {
            if (thirdCoef < 0)
            {
                Console.WriteLine("no real roots");
                return;
            }
            else
            {
                roots[0] = Math.Sqrt(thirdCoef);
                roots[1] = Math.Sqrt(thirdCoef) * (-1);
            }
        }
        else
        {
            double discriminant = (secondCoef * secondCoef) - (firstCoef * thirdCoef * 4.0);
            if (discriminant < 0)
            {
                Console.WriteLine("no real roots");
                return;
            }
            else if (discriminant == 0)
            {
                roots[0] = roots[1] = -secondCoef / (firstCoef * 2.0);
                Console.WriteLine("x1=x2={0}", roots[1]);
                return;
            }
            else
            {
                roots[0] = (-secondCoef + Math.Sqrt(discriminant)) / (firstCoef * 2.0);
                roots[1] = (-secondCoef - Math.Sqrt(discriminant)) / (firstCoef * 2.0);
            }
        }

        Console.WriteLine("x1={0}; x2={1}", roots[0], roots[1]);
    }
}

