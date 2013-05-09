using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPaketManager.Lib.Controls;
using WinPaketManager.Lib.Managers;
using WinPaketManager.Lib.Objects;

namespace WinPaketManager
{
    public partial class FormMain : Form
    {
        List<Repository> repositories;
        public FormMain()
        {
            InitializeComponent();

            //InitializeLog
            Logging.NewLog += Logging_NewLog;

            repositories = new List<Repository>();
        }

        void Logging_NewLog(string logMessage)
        {
            lbLog.Items.Add(logMessage);
            lbLog.TopIndex = lbLog.Items.Count - 1;
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            gbPakets.Size = new Size((int)(this.ClientSize.Width * 0.8), this.ClientSize.Height);
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            repositories.Add(new Repository("http://outcast-prophets.no-ip.org/rep/"));
            updateToolStripMenuItem.PerformClick();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bvPakets.Items.Clear();
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
                foreach (Paket p in rep.Pakets)
                {
                    Logging.Log("Added {0}", p.Name);
                    ButtonViewButton bvb = new ButtonViewButton(p.Name);
                    bvb.Image = repositories[0].GetImageFromPaket(p);
                    bvPakets.Items.Add(bvb);
                }
            }
            //bvPakets.Invalidate();
        }

        private Paket GetPaketByName(string name)
        {
            foreach (Repository rep in repositories)
            {
                foreach (Paket p in rep.Pakets)
                {
                    if (p.Name == name)
                    {
                        return p;
                    }
                }
            }
            Logging.Log("Paket {0} not found", name);
            return null;
        }

        private void bvPakets_ButtonClick(ButtonViewClickEventArgs e)
        {

        }
    }
}
