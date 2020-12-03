using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using NemzetiVirusbolt.Desktop.Services.Stocks;
using NemzetiVirusbolt.Desktop.Views.Helpers;

namespace NemzetiVirusbolt.Desktop.Views.Components
{
    public partial class StockComponent : UserControl
    {
        private readonly IStockService _stockService;

        public StockComponent(IStockService stockService)
        {
            InitializeComponent();

            _stockService = stockService;
        }

        private async void StockComponent_Load(object sender, EventArgs e)
        {
            await InitializeStocks();
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
    }
}
