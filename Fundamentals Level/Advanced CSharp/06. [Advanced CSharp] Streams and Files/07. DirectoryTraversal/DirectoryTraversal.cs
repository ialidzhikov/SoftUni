using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

class DirectoryTraversal
{
    static void Main()
    {
        string sourceDirectoryPath = "../../";
        
        SortedDictionary<string, SortedDictionary<string, double>> directoryReport = 
            new SortedDictionary<string, SortedDictionary<string, double>>();

        DirectoryInfo sourceDirectoryInfo = new DirectoryInfo(sourceDirectoryPath);
        FileInfo[] directoryFiles = sourceDirectoryInfo.GetFiles();
        string extention = String.Empty;
        string fileName = String.Empty;
        double fileSizeInKB = 0;
        foreach (FileInfo directoryFile in directoryFiles)
        {
            extention = directoryFile.Extension;
            fileName = directoryFile.Name;
            fileSizeInKB = directoryFile.Length / 1000d;

            if (!directoryReport.ContainsKey(extention))
            {
                directoryReport[extention] = new SortedDictionary<string, double>();
            }
            directoryReport[extention].Add(fileName, fileSizeInKB);
        }

        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string fileToWritePath = Path.Combine(desktopPath, "report.txt");
        StreamWriter writerToDesktop =
            new StreamWriter(fileToWritePath, false, Encoding.GetEncoding("windows-1251"));
        using (writerToDesktop)
        {
            foreach (KeyValuePair<string, SortedDictionary<string, double>> pair in directoryReport.OrderByDescending(pair => pair.Value.Count))
            {
                writerToDesktop.WriteLine(pair.Key);
                foreach (KeyValuePair<string, double> subPair in pair.Value.OrderBy(subPair => subPair.Value))
                {
                    writerToDesktop.WriteLine("--{0} - {1}", subPair.Key, subPair.Value);
                }
            }
        }
    }
}

