using System;
using System.Collections;
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            ArrayList stock = new ArrayList();

            if (stock.Contains(searchTextBox.Text))
            {

            }


        }

        private void modifyButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
