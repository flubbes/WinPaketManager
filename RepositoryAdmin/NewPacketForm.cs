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
        public NewPacketForm()
        {
            InitializeComponent();
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

        }
    }
}
