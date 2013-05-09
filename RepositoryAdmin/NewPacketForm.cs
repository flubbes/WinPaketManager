using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepositoryAdmin
{
    public partial class NewPacketForm : Form
    {
        public Packet NewPacket { get; set; }

        public NewPacketForm()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Please select a file";
            openFileDialog1.Filter = "Application files(*.EXE)|*.exe|All files (*.*)|*.*";
        }

        private void NewPacketForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenFile32_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                tbxFile32.Text = openFileDialog1.FileName;
            }
        }

        private void btnOpenFile64_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                tbxFile64.Text = openFileDialog1.FileName;
            }
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                tbxImage.Text = openFileDialog1.FileName;
            }
            openFileDialog1.Filter = "Application files(*.EXE)|*.exe|All files (*.*)|*.*";
        }

        private void btnAddPacket_Click(object sender, EventArgs e)
        {
            this.NewPacket.Name = tbxFile32.Text;
            this.NewPacket.Version = tbxVersion.Text;
            this.NewPacket.File32 = tbxFile32.Text;
            this.NewPacket.File64 = tbxFile64.Text;
            this.NewPacket.Image = tbxImage.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
