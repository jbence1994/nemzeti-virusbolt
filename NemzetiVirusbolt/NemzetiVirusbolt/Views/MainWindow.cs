using System.Windows.Forms;

namespace NemzetiVirusbolt.Views
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
            Form1 login = new Form1();
            login.Show();
        }
    }
}
