using System;
using System.Windows.Forms;

namespace NemzetiVirusbolt.Desktop.Views
{
    public partial class LoginWindow : Form
    {
        private readonly MainWindow _mainWindow;

        public LoginWindow(MainWindow mainWindow)
        {
            InitializeComponent();

            _mainWindow = mainWindow;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Auth...

                Hide();
                _mainWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show
                (
                    ex.Message,
                    string.Empty,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(exitCode: 0);
        }
    }
}
