using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NemzetiVirusbolt.Forms
{
    public partial class Logout : Form
    {
        public Logout()
        {
            InitializeComponent();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login f1 = new Login();
            f1.Show();

        }
    }
}