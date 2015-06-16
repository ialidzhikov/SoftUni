using System;
using System.Collections.Generic;
using Point3DClass;

namespace Paths
{
    public class Paths
    {
        static void Main()
        {
            Path3D pathOne = new Path3D();
            pathOne.Add(new Point3D(3, 3, 0));
            pathOne.Add(new Point3D(-7, 2, 21));
            pathOne.Add(Point3D.StartingPoint3D);

            Path3D pathTwo = new Path3D();
            pathTwo.Add(new Point3D(-1, -2, -5));
            pathTwo.Add(new Point3D(8, 5, 23));

            Path3D pathThree = new Path3D();
            pathThree.Add(Point3D.StartingPoint3D);
            pathThree.Add(new Point3D(-7, 2, 21));
            pathThree.Add(new Point3D(3, 3, 0));

            List<Path3D> paths = new List<Path3D>()
            {
                pathOne,
                pathTwo,
                pathThree,
            };

            Storage.SavePaths(paths);
            Storage.LoadPaths("savedPaths.txt");
        }
    }
}
