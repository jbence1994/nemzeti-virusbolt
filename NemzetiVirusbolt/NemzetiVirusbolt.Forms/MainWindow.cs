using System.Windows.Forms;

namespace NemzetiVirusbolt.Forms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
