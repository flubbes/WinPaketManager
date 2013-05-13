namespace WinPacketManager
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.repositoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPackets = new System.Windows.Forms.GroupBox();
            this.bvPackets = new WinPacketManager.Lib.Controls.ButtonView();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.lbCategories = new System.Windows.Forms.ListBox();
            this.gbCategories = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.gbPackets.SuspendLayout();
            this.gbCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repositoriesToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // repositoriesToolStripMenuItem
            // 
            this.repositoriesToolStripMenuItem.Name = "repositoriesToolStripMenuItem";
            this.repositoriesToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.repositoriesToolStripMenuItem.Text = "Repositories";
            this.repositoriesToolStripMenuItem.Click += new System.EventHandler(this.repositoriesToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // gbPackets
            // 
            this.gbPackets.Controls.Add(this.bvPackets);
            this.gbPackets.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbPackets.Location = new System.Drawing.Point(173, 24);
            this.gbPackets.Name = "gbPackets";
            this.gbPackets.Size = new System.Drawing.Size(657, 222);
            this.gbPackets.TabIndex = 2;
            this.gbPackets.TabStop = false;
            this.gbPackets.Text = "Packets";
            // 
            // bvPackets
            // 
            this.bvPackets.BorderWith = 0;
            this.bvPackets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bvPackets.Location = new System.Drawing.Point(3, 16);
            this.bvPackets.MinimumButtonHeight = 100;
            this.bvPackets.MinimumButtonWidth = 100;
            this.bvPackets.Name = "bvPackets";
            this.bvPackets.ShowBorder = true;
            this.bvPackets.Size = new System.Drawing.Size(651, 203);
            this.bvPackets.TabIndex = 0;
            this.bvPackets.ButtonClick += new WinPacketManager.Lib.Controls.ButtonView.ButtonViewClickEventHandler(this.bvPackets_ButtonClick);
            // 
            // lbLog
            // 
            this.lbLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(0, 246);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(830, 82);
            this.lbLog.TabIndex = 3;
            // 
            // lbCategories
            // 
            this.lbCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.Location = new System.Drawing.Point(3, 16);
            this.lbCategories.MultiColumn = true;
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(164, 203);
            this.lbCategories.TabIndex = 4;
            this.lbCategories.SelectedIndexChanged += new System.EventHandler(this.lbCategories_SelectedIndexChanged);
            // 
            // gbCategories
            // 
            this.gbCategories.Controls.Add(this.lbCategories);
            this.gbCategories.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbCategories.Location = new System.Drawing.Point(0, 24);
            this.gbCategories.Name = "gbCategories";
            this.gbCategories.Size = new System.Drawing.Size(170, 222);
            this.gbCategories.TabIndex = 5;
            this.gbCategories.TabStop = false;
            this.gbCategories.Text = "Categories";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 328);
            this.Controls.Add(this.gbCategories);
            this.Controls.Add(this.gbPackets);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbLog);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(846, 367);
            this.Name = "FormMain";
            this.Text = "WinPacketManager";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbPackets.ResumeLayout(false);
            this.gbCategories.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lib.Controls.ButtonView bvPackets;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem repositoriesToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbPackets;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ListBox lbCategories;
        private System.Windows.Forms.GroupBox gbCategories;
    }
}

