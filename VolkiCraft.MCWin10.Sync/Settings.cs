using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolkiCraft.MCWin10.Sync
{
    public class Settings
    {
        internal string BackupDataFile = "BackupData.txt";
        internal string BackupExtension = ".MCw10.zip";
        internal string MCWordlFolder { get; set; } = @"%USERPROFILE%\AppData\Local\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\LocalState\games\com.mojang\minecraftWorlds";
        internal string BackupWorldFolder { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    }
}
