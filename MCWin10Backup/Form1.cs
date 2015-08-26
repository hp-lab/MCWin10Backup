using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolkiCraft.MCWin10.Sync;
using VolkiCraft.MCWin10.Sync.Models;

namespace MCWin10Backup
{
    public partial class Form1 : Form
    {
        WorldTools tool = new WorldTools();

        public Form1()
        {
            InitializeComponent();
        }


        private void restoreBtn_Click(object sender, EventArgs e)
        {
            var w = (World)backupListBox.SelectedItem;
            tool.Restore(w);
            LoadWorlds();
        }

        private void backUpBtn_Click(object sender, EventArgs e)
        {
            var w = (World)mcWorldsListBox.SelectedItem;
            tool.Backup(w);
            LoadWorlds();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            LoadWorlds();
        }

        private void LoadWorlds()
        {
            List<World> mcWorls = tool.ListWorlds().ToList();
            mcWorldsListBox.DataSource = new BindingSource(mcWorls, null);
            mcWorldsListBox.DisplayMember = Extensions.GetPropertyName<World>(w => w.Name);
            mcWorldsListBox.ValueMember = Extensions.GetPropertyName<World>(w => w.Folder);

            List<World> zipWorls = tool.ListBackups().ToList();
            backupListBox.DataSource = new BindingSource(zipWorls, null);
            backupListBox.DisplayMember = Extensions.GetPropertyName<World>(w => w.BackupName);
            backupListBox.ValueMember = Extensions.GetPropertyName<World>(w => w.BackupName);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadWorlds();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(tool.BackupFolder);
        }
    }
}
