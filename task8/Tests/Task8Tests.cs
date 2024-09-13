using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Task8;

namespace Tests
{
    [TestFixture]
    public class Task8Tests
    {
        [Test]
        public void FileList()
        {
            var projectPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            var path = Path.Combine(projectPath, "level1");

            var pathList = new string[]
            {
                Path.Combine(projectPath, "level1/file1"),
                Path.Combine(projectPath, "level1/level2/file2"),
                Path.Combine(projectPath, "level1/level2/file22"),
                Path.Combine(projectPath, "level1/level2/level3/level4/file4")
            };

            var filePaths = FileFinder.FindAllFiles(path);
            Assert.That(filePaths.Count, Is.EqualTo(4));
            Assert.That(filePaths, Is.EquivalentTo(pathList));

            var filePathsArray = FileFinder.FindAllFilesEnumerable(path).ToArray();
            Assert.That(filePathsArray.Length, Is.EqualTo(4));
            Assert.That(filePathsArray, Is.EquivalentTo(pathList));
        }



    }
}
