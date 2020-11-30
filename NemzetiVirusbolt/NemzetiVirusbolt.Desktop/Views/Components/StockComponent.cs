using System;
using System.Linq;
using System.Windows.Forms;
using NemzetiVirusbolt.Core.Repositories;
using NemzetiVirusbolt.Desktop.Dtos;

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

        private void StockComponent_Load(object sender, EventArgs e)
        {
            InitializeStock();
        }

        private async void InitializeStock()
        {
            var stockDtos =
                (from stock in await _stockRepository.GetStocks()
                    select StockDto.ToDto(stock)).ToList();

            dataGridViewStock.DataSource = null;
            dataGridViewStock.DataSource = stockDtos;
        }
    }
}
