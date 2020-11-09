using System;
using System.Windows.Forms;
using NemzetiVirusbolt.DesktopClient.Views.Components;

namespace NemzetiVirusbolt.DesktopClient.Views
{
    public partial class MainWindow : Form
    {
        private readonly TabControlComponent _tabControlComponent;

        public MainWindow(TabControlComponent tabControlComponent)
        {
            InitializeComponent();
            _tabControlComponent = tabControlComponent;
            _tabControlComponent.Dock = DockStyle.Fill;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            panelMain.Controls.Add(_tabControlComponent);
        }
    }
}
