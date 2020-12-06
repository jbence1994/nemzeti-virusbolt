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

                buttonAddStock.Enabled = !buttonAddStock.Enabled;
            }
            catch
            {
                ErrorMessage.DisplayNetworkErrorMessage();
            }
        }

        private async void ButtonAddStock_Click(object sender, EventArgs e)
        {
            var selectedProduct = GetSelectedProduct();

            var stockToSave = new SaveStockDto
            {
                ProductId = selectedProduct.Id,
                Quantity = GetQuantity()
            };

            var validationResult =
                await _stockValidator.ValidateAsync(stockToSave);

            if (!validationResult.IsValid)
            {
                ErrorMessage.DisplayZeroStockQuantityErrorMessage();
                return;
            }

            try
            {
                var result = await _stockService.AddStock(stockToSave);

                MessageBox.Show(result.ProductName); // TODO: wrap mbox ...

                await InitializeStocks();
                await InitializeStockTotalValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ErrorMessage.DisplayNetworkErrorMessage();
            }
        }

        private async Task InitializeStocks()
        {
            dataGridViewStocks.DataSource = await _stockService.GetStocks();
            dataGridViewMergedStocks.DataSource = await _stockService.GetMergedStocks();
        }

        private async Task InitializeProducts()
        {
            comboBoxProducts.DataSource = await _productService.GetProducts();
        }

        private async Task InitializeStockTotalValue()
        {
            var stockTotalValue = await _stockService.GetStockTotalValue();
            textBoxTotalValue.Text = stockTotalValue.TotalValue.ToString("C0");
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
