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
            try
            {
                await InitializeStocks();
                await InitializeProducts();
                await InitializeStockTotalValue();

                buttonAddStock.Enabled =
                    !buttonAddStock.Enabled;
            }
            catch
            {
                PopupMessage.DisplayNetworkErrorMessage();
            }
        }

        private async void ButtonAddStock_Click(object sender, EventArgs e)
        {
            var selectedProduct =
                GetSelectedProduct();

            var stockToSave = new SaveStockDto
            {
                ProductId = selectedProduct.Id,
                Quantity = GetQuantity()
            };

            var validationResult =
                await _stockValidator.ValidateAsync(stockToSave);

            if (!validationResult.IsValid)
            {
                PopupMessage.DisplayZeroStockQuantityErrorMessage();
                return;
            }

            try
            {
                var result =
                    await _stockService.AddStock(stockToSave);

                PopupMessage.DisplayAddStockMessage(result);

                await InitializeStocks();
                await InitializeStockTotalValue();
            }
            catch
            {
                PopupMessage.DisplayNetworkErrorMessage();
            }
        }

        private async void ComboBoxProducts_DropDown(object sender, EventArgs e)
        {
            await InitializeProducts();
        }

        private async Task InitializeStocks()
        {
            dataGridViewStocks.DataSource =
                await _stockService.GetStocks();

            dataGridViewMergedStocks.DataSource =
                await _stockService.GetMergedStocks();
        }

        private async Task InitializeProducts()
        {
            comboBoxProducts.DataSource =
                await _productService.GetProducts();
        }

        private async Task InitializeStockTotalValue()
        {
            var stockTotalValue =
                await _stockService.GetStockTotalValue();

            textBoxTotalValue.Text =
                stockTotalValue.TotalValue.ToString("C0");
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
