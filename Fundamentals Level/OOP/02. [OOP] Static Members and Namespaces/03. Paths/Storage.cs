using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Paths
{
    public static class Storage
    {
        #region Methods

        public static void SavePaths(List<Path3D> paths)
        {
            using (StreamWriter writer = new StreamWriter("savedPaths.txt", false, Encoding.UTF8))
            {
                for (int i = 0; i < paths.Count; i++)
                {
                    writer.WriteLine("Path {0}", i);
                    for (int j = 0; j < paths[i].Path.Count; j++)
                    {
                        writer.WriteLine("Point3D {0,-2}: {1}", j, paths[i].Path[j]);
                    }
                }
            }
        }

        public static void LoadPaths(string pathToLoad)
        {
            using (StreamReader reader = new StreamReader(pathToLoad, Encoding.UTF8))
            {
                string currentLine = reader.ReadLine();
                while (currentLine != null)
                {
                    Console.WriteLine(currentLine);
                    currentLine = reader.ReadLine();
                }
            }
        }

        #endregion
    }
}
