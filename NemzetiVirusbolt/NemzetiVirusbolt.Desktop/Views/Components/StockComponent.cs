using System;
using System.Windows.Forms;
using NemzetiVirusbolt.Core.Repositories;

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

        }
    }
}
