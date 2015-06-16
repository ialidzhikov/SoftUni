using System;
using System.Collections.Generic;
using Point3DClass;

namespace Paths
{
    public class Path3D
    {
        #region Fields

        private List<Point3D> path;

        #endregion

        #region Constructor

        public Path3D()
        {
            this.path = new List<Point3D>();
        }

        #endregion

        #region Properties

        public List<Point3D> Path
        {
            get { return this.path; }
        }

        #endregion

        #region Methods

        public void Add(Point3D pointToAdd)
        {
            this.Path.Add(pointToAdd);
        }

        #endregion
    }
}
