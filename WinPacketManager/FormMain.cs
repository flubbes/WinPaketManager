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
        List<Repository> repositories;
        List<string> categories;
        string curLog;

        public FormMain()
        {
            InitializeComponent();
            Logging.NewLog += Logging_NewLog;
            categories = new List<string>();
            repositories = new List<Repository>();
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
            repositories.Add(new Repository("http://outcast-prophets.no-ip.org/rep/"));
            updateToolStripMenuItem.PerformClick();
            if (lbCategories.Items.Count > 0)
                lbCategories.SelectedIndex = 0;
        }

        private void AddCategory(string cat)
        {
            foreach (string catName in categories)
                if (catName == cat)
                    return;
            categories.Add(cat);
            categories.Sort();
            RefreshCategoryListBox();
        }

        private void RefreshCategoryListBox()
        {
            lbCategories.Items.Clear();
            foreach (string catName in categories)
                lbCategories.Items.Add(catName);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bvPackets.Items.Clear();
            foreach (Repository rep in repositories)
            {
                try
                {
                    rep.Update();
                }
                catch(Exception ex)
                {
                    Logging.Log("{0}: {1}", ex.GetType(), ex.Message);
                }
                foreach (Packet p in rep.Packets)
                {
                    AddCategory(p.Category);
                    Logging.Log("Added {0}", p.Name);
                }
            }
            bvPackets.Invalidate();
        }

        private Packet GetPacketByName(string name)
        {
            foreach (Repository rep in repositories)
                foreach (Packet p in rep.Packets)
                    if (p.Name == name) return p;
            Logging.Log("Packet {0} not found", name);
            return null;
        }

        private Packet[] GetPacketsFromCategory(string catName)
        {
            List<Packet> result = new List<Packet>();
            foreach (Repository rep in repositories)
                foreach (Packet p in rep.Packets)
                    if (p.Category == catName)
                        result.Add(p);
            return result.ToArray();
        }

        private void bvPackets_ButtonClick(ButtonViewClickEventArgs e)
        {
            Packet toInstall = GetPacketByName(e.Button.Caption);
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
            Packet[] packets = GetPacketsFromCategory((string)lbCategories.SelectedItem);
            foreach (Packet p in packets)
            {
                ButtonViewButton bvb = new ButtonViewButton(p.Name);
                bvb.Image = p.ReferencedRepository.GetImageFromPacket(p);
                bvPackets.Items.Add(bvb);
            }
            bvPackets.Invalidate();
        }

        private void repositoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRepositoryManager frm = new FormRepositoryManager(ref repositories);
            frm.ShowDialog();
        }
    }
}
