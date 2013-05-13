namespace WinPacketManager
{
    partial class FormDetails
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblPacketName = new System.Windows.Forms.Label();
            this.lblPacketVersion = new System.Windows.Forms.Label();
            this.btnInstall = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(291, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(137, 137);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // lblPacketName
            // 
            this.lblPacketName.AutoSize = true;
            this.lblPacketName.Location = new System.Drawing.Point(29, 27);
            this.lblPacketName.Name = "lblPacketName";
            this.lblPacketName.Size = new System.Drawing.Size(38, 13);
            this.lblPacketName.TabIndex = 1;
            this.lblPacketName.Text = "Name:";
            // 
            // lblPacketVersion
            // 
            this.lblPacketVersion.AutoSize = true;
            this.lblPacketVersion.Location = new System.Drawing.Point(22, 51);
            this.lblPacketVersion.Name = "lblPacketVersion";
            this.lblPacketVersion.Size = new System.Drawing.Size(45, 13);
            this.lblPacketVersion.TabIndex = 2;
            this.lblPacketVersion.Text = "Version:";
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(15, 167);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 3;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 76);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 13);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category: ";
            // 
            // FormDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 202);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.lblPacketVersion);
            this.Controls.Add(this.lblPacketName);
            this.Controls.Add(this.pbImage);
            this.Name = "FormDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Details";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblPacketName;
        private System.Windows.Forms.Label lblPacketVersion;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Label lblCategory;
    }
}