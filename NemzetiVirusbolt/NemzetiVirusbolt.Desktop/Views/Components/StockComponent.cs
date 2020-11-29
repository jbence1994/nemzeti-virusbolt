using System;
using System.Windows.Forms;
using NemzetiVirusbolt.Core.Repositories;

namespace NemzetiVirusbolt.Desktop.Views.Components
{
    public partial class StockComponent : UserControl
    {
        private readonly IProductRepository _productRepository;

        public StockComponent(IProductRepository productRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
        }

        private void StockComponent_Load(object sender, EventArgs e)
        {
            dataGridViewStock.DataSource = _productRepository.GetProducts();
        }
    }
}
