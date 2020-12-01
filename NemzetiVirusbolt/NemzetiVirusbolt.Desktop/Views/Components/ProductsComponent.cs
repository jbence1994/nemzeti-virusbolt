using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using NemzetiVirusbolt.Desktop.Dtos;
using NemzetiVirusbolt.Desktop.Services.Suppliers;
using NemzetiVirusbolt.Desktop.Views.Helpers;

namespace NemzetiVirusbolt.Desktop.Views.Components
{
    public partial class ProductsComponent : UserControl
    {
        private readonly ISupplierService _supplierService;
        //private readonly IProductRepository _productRepository;
        //private readonly IUnitOfWork _unitOfWork;

        public ProductsComponent(
            //IProductRepository productRepository,
            //IUnitOfWork unitOfWork
            ISupplierService supplierService
        )
        {
            InitializeComponent();

            _supplierService = supplierService;

            //_productRepository = productRepository;
            //_unitOfWork = unitOfWork;
        }

        public async void ProductsComponent_Load(object sender, EventArgs e)
        {
            await InitializeSuppliers();
        }

        private async void ButtonLoadProducts_Click(object sender, EventArgs e)
        {
            await Task.Run(InitializeProducts);
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
            //try
            //{
            //    var productDtos =
            //        (from product in await _productRepository.GetProducts()
            //            select ProductDto.ToDto(product)).ToList();

            //    dataGridViewProducts.DataSource = null;
            //    dataGridViewProducts.DataSource = productDtos;

            //    buttonAddProduct.Enabled = !buttonAddProduct.Enabled;
            //    buttonLoadProducts.Enabled = !buttonLoadProducts.Enabled;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //ErrorMessage.DisplayNetworkErrorMessage();
            //}
        }

        private async Task InitializeSuppliers()
        {
            try
            {
                var supplierDtos =
                    await _supplierService.GetSuppliers();

                comboBoxSuppliers.DataSource = null;
                comboBoxSuppliers.DataSource = supplierDtos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
