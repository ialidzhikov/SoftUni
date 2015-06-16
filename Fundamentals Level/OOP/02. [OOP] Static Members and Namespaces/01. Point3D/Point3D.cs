using System;
using System.Runtime.CompilerServices;

namespace Point3DClass
{
    public class Point3D
    {
        #region Fields

        private double x;
        private double y;
        private double z;

        private static readonly Point3D StartingPoint = new Point3D(0, 0, 0); 

        #endregion

        #region Constructors

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        #endregion

        #region Properties

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public static Point3D StartingPoint3D
        {
            get { return StartingPoint; }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("Point3D - X: {0,-5:F2}, Y: {1,-5:F2}, Z: {2,-5:F2}", this.X, this.Y, this.Z);
        }

        #endregion

        static void Main()
        {
            Console.WriteLine(Point3D.StartingPoint3D);
        }
    }
}
