using System;
using System.Windows.Forms;
using NemzetiVirusbolt.Desktop.Views.Components;

namespace NemzetiVirusbolt.Desktop.Views
{
    public partial class MainWindow : Form
    {
        private readonly StockComponent _stockComponent;

        public MainWindow(StockComponent stockComponent)
        {
            InitializeComponent();
            _stockComponent = stockComponent;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            _stockComponent.Dock = DockStyle.Fill;
            tabPageStock.Controls.Add(_stockComponent);
        }
    }
}
