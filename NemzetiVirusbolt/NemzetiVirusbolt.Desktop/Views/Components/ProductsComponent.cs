using System;
using System.Linq;
using System.Windows.Forms;
using NemzetiVirusbolt.Core;
using NemzetiVirusbolt.Core.Models;
using NemzetiVirusbolt.Core.Repositories;
using NemzetiVirusbolt.Desktop.Dtos;

namespace NemzetiVirusbolt.Desktop.Views.Components
{
    public partial class ProductsComponent : UserControl
    {
        private readonly IProductRepository _productRepository;
        private readonly ISupplierRepository _supplierRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductsComponent(
            IProductRepository productRepository,
            ISupplierRepository supplierRepository,
            IUnitOfWork unitOfWork
        )
        {
            InitializeComponent();

            _productRepository = productRepository;
            _supplierRepository = supplierRepository;
            _unitOfWork = unitOfWork;
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

            dataGridViewProducts.DataSource = null;
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

        private SupplierDto GetSelectedSupplier()
        {
            return (SupplierDto) comboBoxSuppliers.SelectedItem;
        }

        private Product GetProduct()
        {
            // TODO: this is the application's boundary, need to validate data ...

            var productDto = new ProductDto
            {
                Name = textBoxProductName.Text,
                Price = textBoxProductPrice.Text,
                Unit = textBoxProductUnit.Text,
                Description = textBoxProductDescription.Text
            };

            return ProductDto.ToModel(productDto);
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            var selectedSupplier = GetSelectedSupplier();

            var newProduct = GetProduct();
            newProduct.SupplierId = selectedSupplier.Id;

            _productRepository.AddProduct(newProduct);
            _unitOfWork.Complete();

            MessageBox.Show(
                "Termék hozzáadásra került.",
                string.Empty,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            InitializeProducts();
        }
    }
}
