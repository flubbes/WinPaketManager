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
            this.bvTopPakets = new WinPaketManager.Lib.Controls.ButtonView();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bvTopPakets
            // 
            this.bvTopPakets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bvTopPakets.BorderWith = 0;
            this.bvTopPakets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bvTopPakets.Location = new System.Drawing.Point(0, 24);
            this.bvTopPakets.MinimumButtonHeight = 100;
            this.bvTopPakets.MinimumButtonWidth = 100;
            this.bvTopPakets.Name = "bvTopPakets";
            this.bvTopPakets.ShowBorder = true;
            this.bvTopPakets.Size = new System.Drawing.Size(820, 295);
            this.bvTopPakets.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 319);
            this.Controls.Add(this.bvTopPakets);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "WinPaketManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lib.Controls.ButtonView bvTopPakets;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

