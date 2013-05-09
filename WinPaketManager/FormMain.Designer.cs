namespace WinPaketManager
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
            this.gbPakets = new System.Windows.Forms.GroupBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bvPakets = new WinPaketManager.Lib.Controls.ButtonView();
            this.menuStrip1.SuspendLayout();
            this.gbPakets.SuspendLayout();
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
            // 
            // gbPakets
            // 
            this.gbPakets.Controls.Add(this.bvPakets);
            this.gbPakets.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbPakets.Location = new System.Drawing.Point(173, 24);
            this.gbPakets.Name = "gbPakets";
            this.gbPakets.Size = new System.Drawing.Size(657, 222);
            this.gbPakets.TabIndex = 2;
            this.gbPakets.TabStop = false;
            this.gbPakets.Text = "Pakets";
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
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // bvPakets
            // 
            this.bvPakets.BorderWith = 0;
            this.bvPakets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bvPakets.Location = new System.Drawing.Point(3, 16);
            this.bvPakets.MinimumButtonHeight = 100;
            this.bvPakets.MinimumButtonWidth = 100;
            this.bvPakets.Name = "bvPakets";
            this.bvPakets.ShowBorder = true;
            this.bvPakets.Size = new System.Drawing.Size(651, 203);
            this.bvPakets.TabIndex = 0;
            this.bvPakets.ButtonClick += new WinPaketManager.Lib.Controls.ButtonView.ButtonViewClickEventHandler(this.bvPakets_ButtonClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 328);
            this.Controls.Add(this.gbPakets);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbLog);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(846, 367);
            this.Name = "FormMain";
            this.Text = "WinPaketManager";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbPakets.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lib.Controls.ButtonView bvPakets;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem repositoriesToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbPakets;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}

