using System.Windows.Forms;
using NemzetiVirusbolt.Desktop.Properties;

namespace NemzetiVirusbolt.Desktop.Views.Helpers
{
    public static class ErrorMessage
    {
        public static void DisplayLoginErrorMessage()
        {
            MessageBox.Show
            (
                Resources.LoginErrorMessage,
                string.Empty,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        public static void DisplayNetworkErrorMessage()
        {
            MessageBox.Show
            (
                Resources.NetworkErrorMessage,
                string.Empty,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public static void DisplayZeroStockQuantityErrorMessage()
        {
            MessageBox.Show
            (
                Resources.ZeroStockQuantity,
                string.Empty,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
    }
}
