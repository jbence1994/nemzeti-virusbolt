using System;
using System.Windows.Forms;

namespace NemzetiVirusbolt.DesktopClient.Views
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var tabControlComponent = new TabControlComponent {Dock = DockStyle.Fill};
            panelMain.Controls.Add(tabControlComponent);
        }
    }
}
