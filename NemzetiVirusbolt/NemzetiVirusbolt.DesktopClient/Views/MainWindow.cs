using System;
using System.Windows.Forms;
using NemzetiVirusbolt.DesktopClient.Views.Components;

namespace NemzetiVirusbolt.DesktopClient.Views
{
    public partial class MainWindow : Form
    {
        private readonly AddProductComponent _addProductComponent;
        private readonly SearchComponent _searchComponent;
        private readonly StockComponent _stockComponent;

        public MainWindow
        (AddProductComponent addProductComponent,
            SearchComponent searchComponent,
            StockComponent stockComponent)
        {
            InitializeComponent();

            _addProductComponent = addProductComponent;
            _searchComponent = searchComponent;
            _stockComponent = stockComponent;

            _addProductComponent.Dock = DockStyle.Fill;
            _searchComponent.Dock = DockStyle.Fill;
            _stockComponent.Dock = DockStyle.Fill;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            tabPageAddProduct.Controls.Add(_addProductComponent);
            tabPageSearch.Controls.Add(_searchComponent);
            tabPageStock.Controls.Add(_stockComponent);
        }

    }
}
