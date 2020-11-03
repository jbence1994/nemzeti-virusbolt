using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NemzetiVirusbolt
{
   
    public partial class Registry : Form
    {
        string[] inputs = new string[4];

        string pass1;
        string pass2;
        string name;
        string email;
        public Registry()
        {
            InitializeComponent();
        }


        private void registryNowButton_Click(object sender, EventArgs e)
        {

            pass1 = passwordText.Text;
            pass2 = password2Text.Text;
            name = nameText.Text;
            email = emailText.Text;

            inputs[0] = name;
            inputs[1] = pass1;
            inputs[2] = pass2;
            inputs[3] = email;


            if ( name.Length!=0 && pass1 == pass2 && isValidEmailAddress())
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
        private bool isEmpty(String[]inputs)
        {
            bool empty = false;
            foreach (string i in inputs)
            {
                if (i.Equals(""))
                {
                    empty = true;
                }
            }
            if (empty)
                MessageBox.Show("Üres bemenet", "Minden mezőt ki kell tölteni!");
            return empty;
        }
        public bool isValidEmailAddress()
        {

            bool valid = true;
            System.Text.RegularExpressions.Regex regex = new Regex("[a-zA-Z0-9._%-]{1,}@[a-zA-Z0-9.-]{1,}\\.[a-zA-Z]{2,4}");
            Match match = regex.Match(email);
            if (match.Success)
            {
                valid = true;
                Console.WriteLine(match.Value);
            }
            //String validEmail = ("[a-zA-Z0-9._%-]{1,}@[a-zA-Z0-9.-]{1,}\\.[a-zA-Z]{2,4}");
           
            else
            {
                MessageBox.Show(" Hibás email" + email);
            }

            return valid;
        }
    }
}
