using System;
using System.Windows.Forms;

namespace NemzetiVirusbolt.DesktopClient.Views.Components
{
    public partial class TabControlComponent : UserControl
    {
        private readonly StockComponent _stockComponent;

        public TabControlComponent(StockComponent stockComponent)
        {
            InitializeComponent();
            _stockComponent = stockComponent;
            _stockComponent.Dock = DockStyle.Fill;
        }

        private void TabControlComponent_Load(object sender, EventArgs e)
        {
            tabPageStock.Controls.Add(_stockComponent);
        }
    }
}
