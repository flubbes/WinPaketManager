namespace RepositoryAdmin
{
    partial class NewPacketForm
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFile32 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile32 = new System.Windows.Forms.Button();
            this.tbxFile32 = new System.Windows.Forms.TextBox();
            this.tbxFile64 = new System.Windows.Forms.TextBox();
            this.btnOpenFile64 = new System.Windows.Forms.Button();
            this.lblFile64 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(79, 10);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(316, 20);
            this.tbxName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 36);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(48, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblFile32
            // 
            this.lblFile32.AutoSize = true;
            this.lblFile32.Location = new System.Drawing.Point(12, 59);
            this.lblFile32.Name = "lblFile32";
            this.lblFile32.Size = new System.Drawing.Size(59, 13);
            this.lblFile32.TabIndex = 4;
            this.lblFile32.Text = "File (32Bit):";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFile32
            // 
            this.btnOpenFile32.Location = new System.Drawing.Point(324, 55);
            this.btnOpenFile32.Name = "btnOpenFile32";
            this.btnOpenFile32.Size = new System.Drawing.Size(71, 20);
            this.btnOpenFile32.TabIndex = 5;
            this.btnOpenFile32.Text = "Browse...";
            this.btnOpenFile32.UseVisualStyleBackColor = true;
            this.btnOpenFile32.Click += new System.EventHandler(this.btnOpenFile32_Click);
            // 
            // tbxFile32
            // 
            this.tbxFile32.Location = new System.Drawing.Point(79, 55);
            this.tbxFile32.Name = "tbxFile32";
            this.tbxFile32.Size = new System.Drawing.Size(239, 20);
            this.tbxFile32.TabIndex = 6;
            // 
            // tbxFile64
            // 
            this.tbxFile64.Location = new System.Drawing.Point(79, 79);
            this.tbxFile64.Name = "tbxFile64";
            this.tbxFile64.Size = new System.Drawing.Size(239, 20);
            this.tbxFile64.TabIndex = 9;
            // 
            // btnOpenFile64
            // 
            this.btnOpenFile64.Location = new System.Drawing.Point(324, 79);
            this.btnOpenFile64.Name = "btnOpenFile64";
            this.btnOpenFile64.Size = new System.Drawing.Size(71, 20);
            this.btnOpenFile64.TabIndex = 8;
            this.btnOpenFile64.Text = "Browse...";
            this.btnOpenFile64.UseVisualStyleBackColor = true;
            this.btnOpenFile64.Click += new System.EventHandler(this.btnOpenFile64_Click);
            // 
            // lblFile64
            // 
            this.lblFile64.AutoSize = true;
            this.lblFile64.Location = new System.Drawing.Point(12, 82);
            this.lblFile64.Name = "lblFile64";
            this.lblFile64.Size = new System.Drawing.Size(63, 13);
            this.lblFile64.TabIndex = 7;
            this.lblFile64.Text = "File (64Bit*):";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(79, 102);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(239, 20);
            this.textBox4.TabIndex = 12;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(324, 102);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(71, 20);
            this.btnOpenImage.TabIndex = 11;
            this.btnOpenImage.Text = "Browse...";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(12, 105);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(42, 13);
            this.lblImage.TabIndex = 10;
            this.lblImage.Text = "Image: ";
            // 
            // NewPacketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 171);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.tbxFile64);
            this.Controls.Add(this.btnOpenFile64);
            this.Controls.Add(this.lblFile64);
            this.Controls.Add(this.tbxFile32);
            this.Controls.Add(this.btnOpenFile32);
            this.Controls.Add(this.lblFile32);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbxName);
            this.Name = "NewPacketForm";
            this.Text = "Add a new Packet";
            this.Load += new System.EventHandler(this.NewPacketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFile32;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenFile32;
        private System.Windows.Forms.TextBox tbxFile32;
        private System.Windows.Forms.TextBox tbxFile64;
        private System.Windows.Forms.Button btnOpenFile64;
        private System.Windows.Forms.Label lblFile64;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Label lblImage;
    }
}