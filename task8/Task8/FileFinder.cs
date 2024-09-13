using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task8
{
    public class FileFinder
    {
        public static List<string> FindAllFiles(string path)
        {
            var filePaths = new List<string>();
            var isDirectory = File
                .GetAttributes(path)
                .HasFlag(FileAttributes.Directory);

            if (!isDirectory)
            {
                filePaths.Add(path);
                return filePaths;
            }

            foreach (var entryPath in Directory.GetFileSystemEntries(path))
                filePaths.AddRange(FindAllFiles(entryPath));

            return filePaths;
        }

        public static IEnumerable<string> FindAllFilesEnumerable(string path)
        {
            var isDirectory = File
                .GetAttributes(path)
                .HasFlag(FileAttributes.Directory);

            if (!isDirectory)
            {
                yield return path; 
                yield break;
            }

            var filePaths = Directory
                .GetFileSystemEntries(path)
                .SelectMany(entryPath => FindAllFilesEnumerable(entryPath));

            foreach (var filePath in filePaths)
                yield return filePath;

            yield break;
        }

    }

}