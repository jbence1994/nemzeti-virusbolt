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

                buttonAddProduct.Enabled =
                    !buttonAddProduct.Enabled;
            }
            catch
            {
                PopupMessage.DisplayNetworkErrorMessage();
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
                // TODO: show PopupMessage ....
                return;
            }

            try
            {
                var result =
                    await _productService.AddProduct(productToSave);

                MessageBox.Show(result.ToString());
                // TODO: wrap mbox ...

                await InitializeProducts();
            }
            catch
            {
                PopupMessage.DisplayNetworkErrorMessage();
            }
        }

        private async Task InitializeProducts()
        {
            dataGridViewProducts.DataSource =
                await _productService.GetProducts();
        }

        private async Task InitializeSuppliers()
        {
            comboBoxSuppliers.DataSource =
                await _supplierService.GetSuppliers();
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
