using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using NemzetiVirusbolt.Desktop.Dtos;
using NemzetiVirusbolt.Desktop.Services.Products;
using NemzetiVirusbolt.Desktop.Services.Suppliers;
using NemzetiVirusbolt.Desktop.Views.Helpers;

namespace NemzetiVirusbolt.Desktop.Views.Components
{
    public partial class ProductsComponent : UserControl
    {
        private readonly IProductService _productService;
        private readonly ISupplierService _supplierService;

        public ProductsComponent(
            IProductService productService,
            ISupplierService supplierService
        )
        {
            InitializeComponent();

            _productService = productService;
            _supplierService = supplierService;
        }

        public async void ProductsComponent_Load(object sender, EventArgs e)
        {
            await InitializeProducts();
            await InitializeSuppliers();
        }

        private async void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            var newProduct = GetProduct();
            //newProduct.SupplierId = GetSelectedSupplier().Id;

            //await _productRepository.AddProduct(newProduct);
            //await _unitOfWork.CompleteAsync();

            // TODO: add new product's row to GUI ...
        }

        private async Task InitializeProducts()
        {
            try
            {
                dataGridViewProducts.DataSource = null;
                dataGridViewProducts.DataSource = await _productService.GetProducts();

                buttonAddProduct.Enabled = !buttonAddProduct.Enabled;
            }
            catch
            {
                ErrorMessage.DisplayNetworkErrorMessage();
            }
        }

        private async Task InitializeSuppliers()
        {
            try
            {
                comboBoxSuppliers.DataSource = null;
                comboBoxSuppliers.DataSource = await _supplierService.GetSuppliers();
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

        private ProductDto GetProduct()
        {
            // TODO: this is the application's boundary, need to validate data ...

            return new ProductDto
            {
                Name = textBoxProductName.Text,
                Price = textBoxProductPrice.Text,
                Unit = textBoxProductUnit.Text,
                Description = textBoxProductDescription.Text,
            };
        }
    }
}
