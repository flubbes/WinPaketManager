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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newRepositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newPacketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPacketForm npf = new NewPacketForm();
            npf.Show();
            Packet newPacket = npf.NewPacket;
            CreateNewPacket(newPacket);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateNewPacket(Packet p)
        {

        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
