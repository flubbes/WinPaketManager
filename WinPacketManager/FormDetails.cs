using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPacketManager.Lib.Managers;
using WinPacketManager.Lib.Objects;

namespace WinPacketManager
{
    public partial class FormDetails : Form
    {
        Packet p;
        public FormDetails(Packet toLoad)
        {
            InitializeComponent();
            this.p = toLoad;
            SetForm();
        }

        void SetForm()
        {
            this.lblPacketName.Text = "Name: " + p.Name;
            this.pbImage.Image = p.ReferencedRepository.GetImageFromPacket(p);
            this.lblPacketVersion.Text = "Version: " + p.Version;
            this.lblCategory.Text = "Category: " + p.Category;
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            try
            {
                new Thread(() => p.ReferencedRepository.InstallPacket(p, true)).Start();
            }
            catch (Exception ex)
            {
                Logging.Log("{0}: {1}", ex.GetType(), ex.Message);
            }
            this.btnInstall.Enabled = false;
        }
    }
}
