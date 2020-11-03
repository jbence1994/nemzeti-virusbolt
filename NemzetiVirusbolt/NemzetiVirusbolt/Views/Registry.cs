using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NemzetiVirusbolt
{
    public partial class Registry : Form
    {
        public Registry()
        {
            InitializeComponent();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void registryNowButton_Click(object sender, EventArgs e)
        {
            string pass1 = passwordText.Text;
            string pass2 = password2Text.Text;
            if (pass1 == pass2)
            {
                this.Hide();
                Form1 login = new Form1();
                login.Show();
            }
            else
            {
                MessageBox.Show("passwords are not equal!");
            }
        }
    }
}
