using System;
using System.Windows.Forms;
using NemzetiVirusbolt.Desktop.Authentication;
using NemzetiVirusbolt.Desktop.Views.Helpers;

namespace NemzetiVirusbolt.Desktop.Views.Windows
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
            catch
            {
                ErrorMessage.DisplayLoginErrorMessage();
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(exitCode: 0);
        }
    }
}
