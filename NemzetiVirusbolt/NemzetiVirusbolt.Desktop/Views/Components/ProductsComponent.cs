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
        private readonly ISupplierRepository _supplierRepository;

        public ProductsComponent(
            IProductRepository productRepository,
            ISupplierRepository supplierRepository
        )
        {
            InitializeComponent();
            _productRepository = productRepository;
            _supplierRepository = supplierRepository;
        }

        private void ProductsComponent_Load(object sender, EventArgs e)
        {
            InitializeProducts();
            InitializeSuppliers();
        }

        private void InitializeProducts()
        {
            var productDtos = _productRepository
                .GetProducts()
                .Select(ProductDto.ToDto)
                .ToList();

            dataGridViewProducts.DataSource = productDtos;
        }

        private void InitializeSuppliers()
        {
            var supplierDtos = _supplierRepository
                .GetSuppliers()
                .Select(SupplierDto.ToDto)
                .ToList();

            comboBoxSuppliers.DataSource = supplierDtos;
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            var selectedSupplier = (SupplierDto) comboBoxSuppliers.SelectedItem;








            MessageBox.Show(
                "Termék hozzáadásra került.",
                string.Empty,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
