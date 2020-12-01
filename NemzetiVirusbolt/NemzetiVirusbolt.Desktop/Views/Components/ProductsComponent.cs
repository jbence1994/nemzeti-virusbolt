using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NemzetiVirusbolt.Core;
using NemzetiVirusbolt.Core.Models;
using NemzetiVirusbolt.Core.Repositories;
using NemzetiVirusbolt.Desktop.Dtos;
using NemzetiVirusbolt.Desktop.Views.Helpers;

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
            await Task.Run(InitializeSuppliers);
        }

        private async void ButtonLoadProducts_Click(object sender, EventArgs e)
        {
            await Task.Run(InitializeProducts);
        }

        private async void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            var newProduct = GetProduct();
            newProduct.SupplierId = GetSelectedSupplier().Id;

            await _productRepository.AddProduct(newProduct);
            await _unitOfWork.CompleteAsync();

            // TODO: add new product's row to GUI ...
        }

        private async Task InitializeProducts()
        {
            try
            {
                var productDtos =
                    (from product in await _productRepository.GetProducts()
                        select ProductDto.ToDto(product)).ToList();

                dataGridViewProducts.DataSource = null;
                dataGridViewProducts.DataSource = productDtos;

                buttonAddProduct.Enabled = !buttonAddProduct.Enabled;
                buttonLoadProducts.Enabled = !buttonLoadProducts.Enabled;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //ErrorMessage.DisplayNetworkErrorMessage();
            }
        }

        private async Task InitializeSuppliers()
        {
            try
            {
                var supplierDtos =
                    (from supplier in await _supplierRepository.GetSuppliers()
                        select SupplierDto.ToDto(supplier)).ToList();

                comboBoxSuppliers.DataSource = null;
                comboBoxSuppliers.DataSource = supplierDtos;
            }
            catch
            {
                ErrorMessage.DisplayNetworkErrorMessage();
            }
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
                Description = textBoxProductDescription.Text,
            };

            return ProductDto.ToModel(productDto);
        }
    }
}
