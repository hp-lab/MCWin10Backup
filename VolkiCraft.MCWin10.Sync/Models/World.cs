using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolkiCraft.MCWin10.Sync.Models
{
    public class World
    {
        public string Name { get; set; }
        public string BackupName { get; set; }
        public string BackupPath{ get; set; }
        public string Folder { get; set; }
        public DateTime Date { get; set; }
    }
}
