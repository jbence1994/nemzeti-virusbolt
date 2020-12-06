using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using NemzetiVirusbolt.Desktop.Dtos;
using NemzetiVirusbolt.Desktop.Services.Products;
using NemzetiVirusbolt.Desktop.Services.Stocks;
using NemzetiVirusbolt.Desktop.Views.Helpers;
using NemzetiVirusbolt.Validation;

namespace NemzetiVirusbolt.Desktop.Views.Components
{
    public partial class StockComponent : UserControl
    {
        private readonly IStockService _stockService;
        private readonly IProductService _productService;
        private readonly StockValidator _stockValidator;

        public StockComponent
        (
            IStockService stockService,
            IProductService productService,
            StockValidator stockValidator
        )
        {
            InitializeComponent();

            _stockService = stockService;
            _productService = productService;
            _stockValidator = stockValidator;
        }

        private async void StockComponent_Load(object sender, EventArgs e)
        {
            await InitializeStocks();
            await InitializeProducts();

            buttonAddStock.Enabled = !buttonAddStock.Enabled;
        }

        private async void ButtonAddStock_Click(object sender, EventArgs e)
        {
            var selectedProduct = GetSelectedProduct();

            var stockToSave = new SaveStockDto
            {
                ProductId = selectedProduct.Id,
                Quantity = GetQuantity()
            };

            var validationResult = await _stockValidator.ValidateAsync(stockToSave);

            if (!validationResult.IsValid)
            {
                ErrorMessage.DisplayZeroStockQuantityErrorMessage();
                return;
            }

            await _stockService.AddStock(stockToSave);

            // TODO: re-init tables ...
        }

        private async Task InitializeStocks()
        {
            try
            {
                dataGridViewStocks.DataSource = await _stockService.GetStocks();
                dataGridViewMergedStocks.DataSource = await _stockService.GetMergedStocks();
            }
            catch
            {
                ErrorMessage.DisplayNetworkErrorMessage();
            }
        }

        private async Task InitializeProducts()
        {
            try
            {
                comboBoxProducts.DataSource = await _productService.GetProducts();
            }
            catch
            {
                ErrorMessage.DisplayNetworkErrorMessage();
            }
        }

        private GetProductDto GetSelectedProduct()
        {
            return (GetProductDto) comboBoxProducts.SelectedItem;
        }

        private int GetQuantity()
        {
            return (int) numericUpDownQuantity.Value;
        }
    }
}
