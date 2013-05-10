using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPacketManager.Lib.Objects;

namespace WinPacketManager
{
    public partial class FormRepositoryManager : Form
    {
        List<Repository> reps;
        List<string> toDel;
        public FormRepositoryManager(List<Repository> repositories)
        {
            InitializeComponent();
            toDel = new List<string>();
            this.reps = repositories;
            foreach (Repository rep in reps)
                lbRepositories.Items.Add(rep.Address);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbRepositories.SelectedIndex != -1)
            {
                toDel.Add((string)lbRepositories.SelectedItem);
                lbRepositories.Items.RemoveAt(lbRepositories.SelectedIndex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!tbRepository.Enabled)
                tbRepository.Enabled = true;
            else
            {
                if (tbRepository.Text.Length >= 5)
                    if(Uri.IsWellFormedUriString(tbRepository.Text, UriKind.Absolute))
                        lbRepositories.Items.Add(tbRepository.Text);
                tbRepository.Enabled = false;
                tbRepository.Text = string.Empty;
            }
        }

        private void FormRepositoryManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (string delAddress in toDel)
            {
            begin:
                foreach(Repository rep in reps)
                    if (rep.Address == delAddress)
                    {
                        reps.Remove(rep);
                        goto begin;
                    }
            }

            foreach (string repString in lbRepositories.Items)
            {
                bool found = false; ;
                foreach (Repository rep in reps)
                    if (rep.Address == repString)
                        found = true;

                if (!found)
                    reps.Add(new Repository(repString));
            }
        }
    }
}
