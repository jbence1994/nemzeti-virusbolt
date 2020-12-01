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

        private async void ButtonLoadStocks_Click(object sender, EventArgs e)
        {
            await Task.Run(InitializeStocksTables);
        }

        private async Task InitializeStocksTables()
        {
            try
            {
                dataGridViewStocks.DataSource =
                    (from stock in await _stockRepository.GetStocks()
                        select StockDto.ToDto(stock)).ToList();

                dataGridViewMergedStocks.DataSource =
                    (from stock in _stockRepository.GetMergedStocks()
                        select MergedStockDto.ToDto(stock.Key, stock.Value)).ToList();

                buttonLoadStocks.Enabled = !buttonLoadStocks.Enabled;
            }
            catch
            {
                ErrorMessage.DisplayNetworkErrorMessage();
            }
        }
    }
}
