using System;
using System.Windows.Forms;
using NemzetiVirusbolt.Core.Repositories;

namespace NemzetiVirusbolt.DesktopClient.Views
{
    public partial class LoginWindow : Form
    {
        private readonly MainWindow _mainWindow;
        private readonly IUserRepository _userRepository;

        public LoginWindow(MainWindow mainWindow, IUserRepository userRepository)
        {
            InitializeComponent();

            _mainWindow = mainWindow;
            _userRepository = userRepository;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;

            try
            {
                _userRepository.Authenticate(username, password);

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
