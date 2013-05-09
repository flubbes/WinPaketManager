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

namespace WinPaketManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            bvTopPakets.Items.Add(new ButtonViewButton("Paket1"));
            bvTopPakets.Items.Add(new ButtonViewButton("Paket2"));
            bvTopPakets.Items.Add(new ButtonViewButton("Paket3"));
            bvTopPakets.Items.Add(new ButtonViewButton("Paket4"));
            bvTopPakets.Items.Add(new ButtonViewButton("Paket5"));
            bvTopPakets.Items.Add(new ButtonViewButton("Paket6"));
            bvTopPakets.Items.Add(new ButtonViewButton("Paket7"));
            bvTopPakets.Items.Add(new ButtonViewButton("Paket8"));
            bvTopPakets.Items.Add(new ButtonViewButton("Paket9"));
            bvTopPakets.Items.Add(new ButtonViewButton("Paket10"));
            bvTopPakets.Items.Add(new ButtonViewButton("Paket11"));
            bvTopPakets.Items.Add(new ButtonViewButton("Paket12"));
            bvTopPakets.Items.Add(new ButtonViewButton("Paket13"));
            bvTopPakets.Items.Add(new ButtonViewButton("Paket14"));
            foreach (ButtonViewButton bvb in bvTopPakets.Items)
            {
                bvb.Image = Image.FromFile("7ziplogo.png");
            }
        }
    }
}
