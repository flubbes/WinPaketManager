namespace WinPacketManager
{
    partial class FormRepositoryManager
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
            this.lbRepositories = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbRepository = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbRepositories
            // 
            this.lbRepositories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRepositories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbRepositories.FormattingEnabled = true;
            this.lbRepositories.Location = new System.Drawing.Point(0, 70);
            this.lbRepositories.Name = "lbRepositories";
            this.lbRepositories.Size = new System.Drawing.Size(369, 171);
            this.lbRepositories.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(282, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbRepository
            // 
            this.tbRepository.Enabled = false;
            this.tbRepository.Location = new System.Drawing.Point(12, 41);
            this.tbRepository.Name = "tbRepository";
            this.tbRepository.Size = new System.Drawing.Size(345, 20);
            this.tbRepository.TabIndex = 3;
            // 
            // FormRepositoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 241);
            this.Controls.Add(this.tbRepository);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbRepositories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormRepositoryManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Repository-Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRepositoryManager_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbRepositories;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbRepository;
    }
}