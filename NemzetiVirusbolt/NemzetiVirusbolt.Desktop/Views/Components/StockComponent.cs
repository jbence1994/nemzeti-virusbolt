using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using NemzetiVirusbolt.Desktop.Dtos;
using NemzetiVirusbolt.Desktop.Views.Helpers;

namespace NemzetiVirusbolt.Desktop.Views.Components
{
    public partial class StockComponent : UserControl
    {
        //private readonly IStockRepository _stockRepository;

        public StockComponent( /*IStockRepository stockRepository*/)
        {
            InitializeComponent();

            //_stockRepository = stockRepository;
        }

        private async void ButtonLoadStocks_Click(object sender, EventArgs e)
        {
            await InitializeStocks();
        }

        private async Task InitializeStocks()
        {
            //try
            //{
            //    dataGridViewStocks.DataSource =
            //        (from stock in await _stockRepository.GetStocks()
            //            select StockDto.ToDto(stock)).ToList();

            //    dataGridViewMergedStocks.DataSource =
            //        (from stock in _stockRepository.GetMergedStocks()
            //            select MergedStockDto.ToDto(stock.Key, stock.Value)).ToList();

            //    buttonLoadStocks.Enabled = !buttonLoadStocks.Enabled;
            //}
            //catch
            //{
            //    ErrorMessage.DisplayNetworkErrorMessage();
            //}
        }
    }
}
