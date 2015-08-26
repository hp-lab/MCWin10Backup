namespace MCWin10Backup
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.restoreBtn = new System.Windows.Forms.Button();
            this.backUpBtn = new System.Windows.Forms.Button();
            this.backupListBox = new System.Windows.Forms.ListBox();
            this.mcWorldsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reload = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(440, 137);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(79, 46);
            this.restoreBtn.TabIndex = 1;
            this.restoreBtn.Text = "->";
            this.restoreBtn.UseVisualStyleBackColor = true;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // backUpBtn
            // 
            this.backUpBtn.Location = new System.Drawing.Point(440, 189);
            this.backUpBtn.Name = "backUpBtn";
            this.backUpBtn.Size = new System.Drawing.Size(79, 46);
            this.backUpBtn.TabIndex = 1;
            this.backUpBtn.Text = "<-";
            this.backUpBtn.UseVisualStyleBackColor = true;
            this.backUpBtn.Click += new System.EventHandler(this.backUpBtn_Click);
            // 
            // backupListBox
            // 
            this.backupListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.backupListBox.FormattingEnabled = true;
            this.backupListBox.ItemHeight = 20;
            this.backupListBox.Location = new System.Drawing.Point(12, 60);
            this.backupListBox.Name = "backupListBox";
            this.backupListBox.Size = new System.Drawing.Size(422, 404);
            this.backupListBox.TabIndex = 2;
            // 
            // mcWorldsListBox
            // 
            this.mcWorldsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mcWorldsListBox.FormattingEnabled = true;
            this.mcWorldsListBox.ItemHeight = 20;
            this.mcWorldsListBox.Location = new System.Drawing.Point(525, 60);
            this.mcWorldsListBox.Name = "mcWorldsListBox";
            this.mcWorldsListBox.Size = new System.Drawing.Size(375, 404);
            this.mcWorldsListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Backups";
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(440, 32);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(79, 46);
            this.reload.TabIndex = 4;
            this.reload.Text = "reload";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "MC Win 10 Worlds";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Open \'My Documents\' ...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mcWorldsListBox);
            this.Controls.Add(this.backupListBox);
            this.Controls.Add(this.backUpBtn);
            this.Controls.Add(this.restoreBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Minecarft Windows 10 - World Backup Tool";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button restoreBtn;
        private System.Windows.Forms.Button backUpBtn;
        private System.Windows.Forms.ListBox backupListBox;
        private System.Windows.Forms.ListBox mcWorldsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

