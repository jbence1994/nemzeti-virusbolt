using System;
using System.Linq;
using System.Threading.Tasks;
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

        public async void ProductsComponent_Load(object sender, EventArgs e)
        {
            buttonAddProduct.Enabled = !buttonAddProduct.Enabled;
            await InitializeSuppliers();
        }

        private async void ButtonLoadProducts_Click(object sender, EventArgs e)
        {
            await InitializeProducts();
            buttonAddProduct.Enabled = !buttonAddProduct.Enabled;
        }

        private async void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            var selectedSupplier = GetSelectedSupplier();

            var newProduct = GetProduct();
            newProduct.SupplierId = selectedSupplier.Id;

            await _productRepository.AddProduct(newProduct);
            await _unitOfWork.CompleteAsync();

            await InitializeProducts();
        }

        private async Task InitializeProducts()
        {
            var productDtos =
                (from product in await _productRepository.GetProducts()
                    select ProductDto.ToDto(product)).ToList();

            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = productDtos;
        }

        private async Task InitializeSuppliers()
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
    }
}
