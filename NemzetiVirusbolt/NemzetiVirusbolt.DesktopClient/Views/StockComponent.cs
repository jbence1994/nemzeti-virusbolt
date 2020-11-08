using System;
using System.Windows.Forms;
using NemzetiVirusbolt.DesktopClient.Services;

namespace NemzetiVirusbolt.DesktopClient.Views
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
            dataGridViewStock.DataSource = _stockRepository.GetStocks();
        }
    }
}
