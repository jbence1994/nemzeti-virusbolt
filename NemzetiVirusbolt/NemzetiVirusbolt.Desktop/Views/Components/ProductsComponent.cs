using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using NemzetiVirusbolt.Desktop.Dtos;
using NemzetiVirusbolt.Desktop.Services.Products;
using NemzetiVirusbolt.Desktop.Services.Suppliers;
using NemzetiVirusbolt.Desktop.Views.Helpers;
using NemzetiVirusbolt.Validation;

namespace NemzetiVirusbolt.Desktop.Views.Components
{
    public partial class ProductsComponent : UserControl
    {
        private readonly IProductService _productService;
        private readonly ISupplierService _supplierService;
        private readonly ProductValidator _productValidator;

        public ProductsComponent
        (
            IProductService productService,
            ISupplierService supplierService,
            ProductValidator productValidator
        )
        {
            InitializeComponent();

            _productService = productService;
            _supplierService = supplierService;
            _productValidator = productValidator;
        }

        public async void ProductsComponent_Load(object sender, EventArgs e)
        {
            try
            {
                await InitializeProducts();
                await InitializeSuppliers();

                buttonAddProduct.Enabled = !buttonAddProduct.Enabled;
            }
            catch
            {
                ErrorMessage.DisplayNetworkErrorMessage();
            }
        }

        private async void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            var productToSave = GetProduct();
            var selectedSupplier = GetSelectedSupplier();

            productToSave.SupplierId = selectedSupplier.Id;

            var validationResult =
                await _productValidator.ValidateAsync(productToSave);

            if (!validationResult.IsValid)
            {
                //MessageBox.Show("Test");
                return;
            }

            await _productService.AddProduct(productToSave);

            // TODO: add new product's row to GUI ...
        }

        private async Task InitializeProducts()
        {
            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = await _productService.GetProducts();
        }

        private async Task InitializeSuppliers()
        {
            comboBoxSuppliers.DataSource = null;
            comboBoxSuppliers.DataSource = await _supplierService.GetSuppliers();
        }

        private GetSupplierDto GetSelectedSupplier()
        {
            return (GetSupplierDto) comboBoxSuppliers.SelectedItem;
        }

        private SaveProductDto GetProduct()
        {
            return new SaveProductDto
            {
                Name = textBoxProductName.Text,
                Price = textBoxProductPrice.Text,
                Unit = textBoxProductUnit.Text,
                Description = textBoxProductDescription.Text,
            };
        }
    }
}
