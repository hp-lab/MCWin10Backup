using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolkiCraft.MCWin10.Sync.Models;

namespace VolkiCraft.MCWin10.Sync
{
    public class WorldTools
    {
        Settings settings = new Settings();

        public string BackupFolder { get { return Environment.ExpandEnvironmentVariables(settings.BackupWorldFolder); } }
        public string WorldFolder { get { return Environment.ExpandEnvironmentVariables(settings.MCWordlFolder); } }

        public IEnumerable<World> ListWorlds() {
            var dirs = Directory.EnumerateDirectories(WorldFolder);
            var worldNames = dirs
                .Select(d => { Debug.WriteLine(d); return d; })
                .Select(d => { return new World { Folder = d, Name = readWorldNam(d), Date = readDate(d) }; })
                .ToList();
            return worldNames;
        }

        public IEnumerable<World> ListBackups()
        {
            var dirs = Directory.EnumerateFiles(BackupFolder, "*" + settings.BackupExtension);
            var worldNames = dirs
                .Select(d => { Debug.WriteLine(d); return d; })
                .Select(d => { return new World {
                    BackupName = Path.GetFileName(d).Replace(settings.BackupExtension, ""),
                    BackupPath = d
                     
                };
                }).ToList();
            return worldNames;
        }

        public void Backup(World world)
        {
            if (world.Name == null) throw new ArgumentNullException("world.Name");

            var zipFileName = string.Format("{0}_{1:yyyy-MM-dd_HHmmss}{2}", world.Name, DateTime.Now, settings.BackupExtension); 
            var zipPath = Path.Combine(BackupFolder, zipFileName);
            ZipFile.CreateFromDirectory(world.Folder, zipPath);

            using (FileStream zipToOpen = new FileStream(zipPath, FileMode.OpenOrCreate))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    ZipArchiveEntry readmeEntry = archive.CreateEntry(settings.BackupDataFile);
                    using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                    {
                        writer.WriteLine(world.SerializeXML());
                    }
                }
            }
        }

        public void Restore(World world)
        {
            if (world.BackupPath == null) throw new ArgumentNullException("world.BackupPath");

            //        aaaEAP7Z4wQ=
            //        EA0AAIogCQA=
            //        KvMEAEZT4wQ=

            string[] alphaNum = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};

            var n = DateTime.Now;
            string compactDate = alphaNum[n.Year - 2015] + alphaNum[n.Month] + alphaNum[n.Day] + alphaNum[n.Hour] + alphaNum[n.Minute] + alphaNum[n.Second];
            string restorePath = Path.Combine(this.WorldFolder, "MCBR" + compactDate + "1=");
            if(Directory.Exists(restorePath)) restorePath = Path.Combine(this.WorldFolder, "MCBR" + compactDate + "2=");
            Directory.CreateDirectory(restorePath);                                                                                                                          
            ZipFile.ExtractToDirectory(world.BackupPath, restorePath);
        }

        public void Restore(string path)
        {
            var world = extractFromZip(path);
        }

        private string readWorldNam(string worldPath)
        {
            var filePath = Path.Combine(worldPath, "levelname.txt");
            return File.ReadAllText(filePath);
        }

        private DateTime readDate(string path)
        {
            return Directory.GetLastAccessTimeUtc(path);
        }

        private World extractFromZip(string path)
        {
            using (ZipArchive zip = ZipFile.Open(path, ZipArchiveMode.Read))
                foreach (ZipArchiveEntry entry in zip.Entries)
                    if (entry.Name == settings.BackupDataFile)
                        return entry
                            .Open()
                            .ConvertToString()
                            .DeserializeXML<World>();

            return new World { Name = "No Backup Data found" };
        }
    }
}
