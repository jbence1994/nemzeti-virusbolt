using System;
using System.Linq;
using System.Windows.Forms;
using NemzetiVirusbolt.Core.Repositories;
using NemzetiVirusbolt.Desktop.Dtos;

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
            InitializeStock();
        }

        private void InitializeStock()
        {
            var productDtos = _productRepository.GetProducts()
                .Select(ProductDto.ToDto).ToList();

            dataGridViewStock.DataSource = productDtos;
        }
    }
}
