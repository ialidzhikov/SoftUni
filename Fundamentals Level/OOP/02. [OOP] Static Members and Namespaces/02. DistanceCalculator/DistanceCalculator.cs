using System;
using Point3DClass;

namespace DistanceCalculator
{
    public class DistanceCalculator
    {
        public static double CalculateDistance(Point3D start, Point3D end)
        {
            double deltaDistance = Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2) +
                                   Math.Pow(end.Z - start.Z, 2);
            return Math.Sqrt(deltaDistance);
        }

        static void Main()
        {
            Point3D startPoint3D = new Point3D(3, 3, -14.4);
            Point3D endPoint3D = new Point3D(0, -3, 0);
            Console.WriteLine(CalculateDistance(startPoint3D, endPoint3D));
        }
    }
}
