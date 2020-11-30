using System;
using System.Collections.Generic;
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

        private async void InitializeProducts()
        {
            var productDtos =
                (from product in await _productRepository.GetProducts()
                    select ProductDto.ToDto(product)).ToList();

            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = productDtos;
        }

        private async void InitializeSuppliers()
        {
            var supplierDtos =
                (from supplier in await _supplierRepository.GetSuppliers()
                    select SupplierDto.ToDto(supplier)).ToList();

            comboBoxSuppliers.DataSource = null;
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

        private async void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            var selectedSupplier = GetSelectedSupplier();

            var newProduct = GetProduct();
            newProduct.SupplierId = selectedSupplier.Id;

            await _productRepository.AddProduct(newProduct);
            await _unitOfWork.CompleteAsync();

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
