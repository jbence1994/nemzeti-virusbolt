using System;
using System.Windows.Forms;
using NemzetiVirusbolt.Desktop.Views.Components;

namespace NemzetiVirusbolt.Desktop.Views
{
    public partial class MainWindow : Form
    {
        private readonly SearchComponent _searchComponent;
        private readonly StockComponent _stockComponent;
        private readonly ProductsComponent _centralStockComponent;

        public MainWindow
        (
            SearchComponent searchComponent,
            StockComponent stockComponent,
            ProductsComponent centralStockComponent)
        {
            InitializeComponent();

            _searchComponent = searchComponent;
            _stockComponent = stockComponent;
            _centralStockComponent = centralStockComponent;

            _searchComponent.Dock = DockStyle.Fill;
            _stockComponent.Dock = DockStyle.Fill;
            _centralStockComponent.Dock = DockStyle.Fill;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            tabPageSearch.Controls.Add(_searchComponent);
            tabPageStock.Controls.Add(_stockComponent);
            tabPageCentralStock.Controls.Add(_centralStockComponent);
        }
    }
}
