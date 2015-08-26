using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;

namespace VolkiCraft.MCWin10.Sync.Test
{
    [TestClass]
    public class UnitTest1
    {
        WorldTools tools = new WorldTools();

        [TestMethod]
        public void TestMethod1()
        {
            var input = "EA0AAIogCQA= pw4AAJNbAQA=".Split(' ');
            foreach (var d in input)
            {
                var o = Convert.FromBase64String(d);
                Debug.WriteLine(o);
            }
            
        }

        [TestMethod]
        public void CreateZip()
        {
            string zipFile = Path.Combine(tools.BackupFolder, "test.zip");
            using (FileStream zipToOpen = new FileStream(zipFile, FileMode.OpenOrCreate))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    ZipArchiveEntry readmeEntry = archive.CreateEntry("Readme.txt");
                    using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                    {
                        writer.WriteLine("Information about this package.");
                        writer.WriteLine("========================");
                    }
                }
            }
        }

        [TestMethod]
        public void ReadBase64LookingDir()
        {
            string dir = "EA0AAIogCQA=";
            var data = Convert.FromBase64String(dir);
            var ticks = BitConverter.ToInt64(data, 0);
            Debug.WriteLine(ticks);

            DateTime myDate = new DateTime(ticks);
            Debug.WriteLine(myDate);
        }



        [TestMethod]
        public void CreateShort()
        {
        }
    }
}
