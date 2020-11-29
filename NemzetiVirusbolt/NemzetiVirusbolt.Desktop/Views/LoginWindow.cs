using System;
using System.Windows.Forms;
using NemzetiVirusbolt.Desktop.Services.Authentication;

namespace NemzetiVirusbolt.Desktop.Views
{
    public partial class LoginWindow : Form
    {
        private readonly MainWindow _mainWindow;
        private readonly IAuthenticationService _authenticationService;

        public LoginWindow
        (
            MainWindow mainWindow,
            IAuthenticationService authenticationService
        )
        {
            InitializeComponent();

            _mainWindow = mainWindow;
            _authenticationService = authenticationService;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                _authenticationService
                    .Authenticate(textBoxUsername.Text, textBoxPassword.Text);

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
