using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Task8
{
    public class FileFinder
    {
        public static List<string> FindAllFiles(string path)
        {
            var filePaths = new List<string>();
            return FindAllFilesRecusive(path, filePaths);
        }

        private static List<string> FindAllFilesRecusive(string path, List<string> filesPaths)
        {
            var attributes = File.GetAttributes(path);
            var isDirectory = attributes.HasFlag(FileAttributes.Directory);

            if (!isDirectory)
            {
                filesPaths.Add(path);
                return filesPaths;
            }

            foreach (var entryPath in Directory.GetFileSystemEntries(path))
                filesPaths = FindAllFilesRecusive(entryPath, filesPaths);

            return filesPaths;
        }
    }

}