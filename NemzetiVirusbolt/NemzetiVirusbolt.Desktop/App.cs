using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NemzetiVirusbolt.Desktop.Authentication;
using NemzetiVirusbolt.Desktop.Services.Products;
using NemzetiVirusbolt.Desktop.Services.Stocks;
using NemzetiVirusbolt.Desktop.Services.Suppliers;
using NemzetiVirusbolt.Desktop.Views.Components;
using NemzetiVirusbolt.Desktop.Views.Windows;
using NemzetiVirusbolt.Validation;

namespace NemzetiVirusbolt.Desktop
{
    public static class App
    {
        [STAThread]
        public static void Main()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddScoped<IAuthenticationService, AuthenticationService>();
                    services.AddScoped<IProductService, ProductService>();
                    services.AddScoped<IStockService, StockService>();
                    services.AddScoped<ISupplierService, SupplierService>();

                    services.AddScoped<ProductValidator>();
                    services.AddScoped<StockValidator>();

                    services.AddScoped<LoginWindow>();
                    services.AddScoped<MainWindow>();
                    services.AddScoped<ProductsComponent>();
                    services.AddScoped<StockComponent>();
                })
                .Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(host.Services.GetRequiredService<LoginWindow>());
        }
    }
}
