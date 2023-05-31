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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        void OpenMenu()
        {
            Meniu m = new Meniu(usertxt.Text);
            Hide();
            m.ShowDialog();
            Show();
        }

        private void log_Click(object sender, EventArgs e)
        {
            if(usertxt.Text == "admin" && passtxt.Text == "1234")
            {
                MessageBox.Show("Logat ca si Admin");
                OpenMenu();
            } 
            else if(usertxt.Text == "user" && passtxt.Text == "pass")
            {
                MessageBox.Show("Logat ca si Utilizator");
                OpenMenu();
            }
            else if(usertxt.Text == "" || passtxt.Text == "")
            {
                MessageBox.Show("Te rog sa introduci toate datele");
            }
            else
            {
                MessageBox.Show("Nume sau parola gresita");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usertxt.Text = "";
            passtxt.Text = "";
        }
    }
}
