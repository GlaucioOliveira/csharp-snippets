using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace UnitTestProject.IO
{
    [TestClass]
    public class PathTest
    {
        [TestMethod]
        public void CombinePath()
        {
            var drive = "c:\\";
            var directory = "windows\\";
            var file = "notepad.exe";

            var output = Path.Combine(drive, directory, file);

            Assert.IsTrue(output.Equals("c:\\windows\\notepad.exe"));
            
            Debug.Print(output);
        }

        [TestMethod]
        public void Util()
        {
            var input = "c:\\windows\\notes.txt";

            input = Path.ChangeExtension(input, "md");
            
            string fileName = Path.GetFileName(input);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(input);

            bool hasExtension = Path.HasExtension(input);

            input = Path.ChangeExtension(input, null); //remove the extension

            hasExtension = Path.HasExtension(input);

        }

        [TestMethod]
        public void UseFulMethods()
        {
            char[] invalidNameChars = Path.GetInvalidFileNameChars();
            char[] invalidPathChars = Path.GetInvalidPathChars();

            string randomFileName = Path.GetRandomFileName();

            string tempFileName = Path.GetTempFileName();

            string userTempPath = Path.GetTempPath();

            //since it's .net core it can run on windows/linux/mac
            char DirSeparatorChar = Path.DirectorySeparatorChar;

        }
    }
}
