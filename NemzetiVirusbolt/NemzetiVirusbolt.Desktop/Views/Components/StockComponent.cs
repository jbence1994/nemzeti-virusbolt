using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NemzetiVirusbolt.Core.Repositories;
using NemzetiVirusbolt.Desktop.Dtos;
using NemzetiVirusbolt.Desktop.Views.Helpers;

namespace NemzetiVirusbolt.Desktop.Views.Components
{
    public partial class StockComponent : UserControl
    {
        private readonly IStockRepository _stockRepository;

        public StockComponent(IStockRepository stockRepository)
        {
            InitializeComponent();

            _stockRepository = stockRepository;
        }

        private async void ButtonLoadStock_Click(object sender, EventArgs e)
        {
            await InitializeStock();
            InitializeMergedStock();
        }

        private async Task InitializeStock()
        {
            try
            {
                var stockDtos =
                    (from stock in await _stockRepository.GetStocks()
                        select StockDto.ToDto(stock)).ToList();

                dataGridViewStocks.DataSource = stockDtos;
                buttonLoadStocks.Enabled = !buttonLoadStocks.Enabled;
            }
            catch
            {
                ErrorMessage.DisplayNetworkErrorMessage();
            }
        }

        private void InitializeMergedStock()
        {
            try
            {
                var mergedStockDtos =
                    (from stock in _stockRepository.GetMergedStocks()
                        select MergedStockDto.ToDto(stock.Key, stock.Value)).ToList();

                dataGridViewMergedStocks.DataSource = mergedStockDtos;
            }
            catch
            {
                ErrorMessage.DisplayNetworkErrorMessage();
            }
        }
    }
}
