using System;
using System.Windows.Forms;
using NemzetiVirusbolt.Desktop.Views.Components;

namespace NemzetiVirusbolt.Desktop.Views.Windows
{
    public partial class MainWindow : Form
    {
        private readonly StockComponent _stockComponent;
        private readonly ProductsComponent _productsComponent;

        public MainWindow
        (
            StockComponent stockComponent,
            ProductsComponent productsComponent
        )
        {
            InitializeComponent();

            _stockComponent = stockComponent;
            _productsComponent = productsComponent;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            _stockComponent.Dock = DockStyle.Fill;
            tabPageStock.Controls.Add(_stockComponent);

            _productsComponent.Dock = DockStyle.Fill;
            tabPageProducts.Controls.Add(_productsComponent);
        }
    }
}
