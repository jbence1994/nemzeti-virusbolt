using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NemzetiVirusbolt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            string id = userIdText.Text;
            string password = passwordText.Text;

            if(id=="123" && password == "123")
            {
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("ID or password is incorrect!");
            }
        }

        private void buttonRegistry_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registry registry = new Registry();
            registry.Show();
        }
    }
}
