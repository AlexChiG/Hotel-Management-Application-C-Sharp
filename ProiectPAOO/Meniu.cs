using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAOO
{
    public partial class Meniu : Form
    {
        public string user;
        public Meniu(string username)
        {
            InitializeComponent();
            user = username;
        }

        private void ang_Click(object sender, EventArgs e)
        {
            tab_angajat t = new tab_angajat(user);
            Hide();
            t.ShowDialog();
            Show();
        }

        private void dep_Click(object sender, EventArgs e)
        {
            tab_departament t = new tab_departament(user);
            Hide();
            t.ShowDialog();
            Show();
        }
        
        private void cam_Click(object sender, EventArgs e)
        {
            tab_camera t = new tab_camera(user);
            Hide();
            t.ShowDialog();
            Show();
        }

        private void cli_Click(object sender, EventArgs e)
        {
            tab_client t = new tab_client(user);
            Hide();
            t.ShowDialog();
            Show();
        }

        private void fur_Click(object sender, EventArgs e)
        {
            tab_furnizor t = new tab_furnizor(user);
            Hide();
            t.ShowDialog();
            Show();
        }

        private void rez_Click(object sender, EventArgs e)
        {
            tab_rezervare t = new tab_rezervare(user);
            Hide();
            t.ShowDialog();
            Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
