using System;
using System.Linq;
using System.Windows.Forms;
using NemzetiVirusbolt.Core.Repositories;
using NemzetiVirusbolt.Desktop.Dtos;

namespace NemzetiVirusbolt.Desktop.Views.Components
{
    public partial class ProductsComponent : UserControl
    {
        private readonly IProductRepository _productRepository;

        public ProductsComponent(IProductRepository productRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
        }

        private void ProductsComponent_Load(object sender, EventArgs e)
        {
            InitializeProducts();
        }

        private void InitializeProducts()
        {
            var productDtos = _productRepository
                .GetProducts()
                .Select(ProductDto.ToDto)
                .ToList();

            dataGridViewProducts.DataSource = productDtos;
        }
    }
}
