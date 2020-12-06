using System.Collections.Generic;
using System.Windows.Forms;
using FluentValidation.Results;
using NemzetiVirusbolt.Desktop.Dtos;
using NemzetiVirusbolt.Desktop.Properties;

namespace NemzetiVirusbolt.Desktop.Views.Helpers
{
    public static class PopupMessage
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
                Resources.ZeroStockQuantityMessage,
                string.Empty,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        public static void DisplayAddStockMessage(GetStockDto stock)
        {
            MessageBox.Show
            (
                string.Format(Resources.AddStockMessage, stock.ProductName, stock.Quantity),
                string.Empty,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public static void DisplayAddProductMessage(GetProductDto product)
        {
            MessageBox.Show
            (
                string.Format(Resources.AddStockMessage, product.Name, product.SupplierName),
                string.Empty,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public static void DisplayProductValidationErrors(IList<ValidationFailure> validationResultErrors)
        {
            MessageBox.Show
            (
                validationResultErrors.ToString(),
                string.Empty,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
