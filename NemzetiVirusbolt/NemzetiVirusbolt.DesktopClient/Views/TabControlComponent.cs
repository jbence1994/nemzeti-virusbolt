using System;
using System.Windows.Forms;

namespace NemzetiVirusbolt.DesktopClient.Views
{
    public partial class TabControlComponent : UserControl
    {
        public TabControlComponent()
        {
            InitializeComponent();
        }

        private void TabControlComponent_Load(object sender, EventArgs e)
        {
            var stockComponent = new StockComponent {Dock = DockStyle.Fill};
            tabPageStock.Controls.Add(stockComponent);
        }
    }
}
