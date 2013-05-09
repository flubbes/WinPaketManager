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
using WinPaketManager.Lib.Objects;

namespace WinPaketManager
{
    public partial class FormMain : Form
    {
        List<Repository> repositories;
        public FormMain()
        {
            InitializeComponent();
            repositories = new List<Repository>();
            repositories.Add(new Repository("http://outcast-prophets.no-ip.org/rep/"));
            repositories[0].Update();

            foreach (Paket p in repositories[0].Pakets)
            {
                ButtonViewButton bvb = new ButtonViewButton(p.Name);
                bvb.Image = repositories[0].GetImageFromPaket(p);
                bvTopPakets.Items.Add(bvb);
            }
        }
    }
}
