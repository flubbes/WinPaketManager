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
using WinPacketManager.Lib.Controls;
using WinPacketManager.Lib.Managers;
using WinPacketManager.Lib.Objects;

namespace WinPacketManager
{
    public partial class FormMain : Form
    {
        string curLog;

        public FormMain()
        {
            InitializeComponent();
            Logging.NewLog += Logging_NewLog;
            RepositoryManager.Init();
        }

        void Logging_NewLog(string logMessage)
        {
            curLog = logMessage;
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(Log));
            else
                Log();
        }

        private void Log()
        {
            lbLog.Items.Add(curLog);
            lbLog.TopIndex = lbLog.Items.Count - 1;
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            gbPackets.Size = new Size((int)(this.ClientSize.Width * 0.8), this.ClientSize.Height);
            gbCategories.Size = new Size((int)(this.ClientSize.Width * 0.2), this.ClientSize.Height);
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            RepositoryManager.AddRepository(new Repository("http://outcast-prophets.no-ip.org/rep/"));
            updateToolStripMenuItem.PerformClick();
            if (lbCategories.Items.Count > 0)
                lbCategories.SelectedIndex = 0;
        }

        private void RefreshCategoryListBox()
        {
            lbCategories.Items.Clear();
            foreach (string catName in RepositoryManager.Categories)
                lbCategories.Items.Add(catName);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bvPackets.Items.Clear();
            
            RepositoryManager.Update();
            RefreshCategoryListBox();
            bvPackets.Invalidate();
        }


        private void bvPackets_ButtonClick(ButtonViewClickEventArgs e)
        {
            Packet toInstall = RepositoryManager.GetPacketByName(e.Button.Caption);
            try
            {
                new Thread(() => toInstall.ReferencedRepository.InstallPacket(toInstall, true)).Start();
            }
            catch(Exception ex)
            {
                 Logging.Log("{0}: {1}", ex.GetType(), ex.Message);
            }
        }

        private void lbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            bvPackets.Items.Clear();
            //Packet[] packets = RepositoryManager.GetPacketsFromCategory((string)lbCategories.SelectedItem);
            foreach (Repository rep in RepositoryManager.Repositories)
            {
                foreach (Packet p in rep.Packets)
                {
                    ButtonViewButton bvb = new ButtonViewButton(p.Name);
                    bvb.Image = p.ReferencedRepository.GetImageFromPacket(p);
                    bvPackets.Items.Add(bvb);
                }
            }
            bvPackets.Invalidate();
        }

        private void repositoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRepositoryManager frm = new FormRepositoryManager(RepositoryManager.Repositories);
            frm.ShowDialog();
        }
    }
}
