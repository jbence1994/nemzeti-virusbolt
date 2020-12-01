using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NemzetiVirusbolt.Desktop.Services.Authentication;
using NemzetiVirusbolt.Desktop.Services.Suppliers;
using NemzetiVirusbolt.Desktop.Views;
using NemzetiVirusbolt.Desktop.Views.Components;

namespace NemzetiVirusbolt.Desktop
{
    public static class App
    {
        [STAThread]
        public static void Main()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true)
                .Build();

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddScoped<IAuthenticationService, AuthenticationService>();
                    services.AddScoped<ISupplierService, SupplierService>();

                    services.AddScoped<LoginWindow>();
                    services.AddScoped<MainWindow>();
                    services.AddScoped<ProductsComponent>();
                    services.AddScoped<StockComponent>();
                })
                .Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(host.Services.GetRequiredService<MainWindow>());
        }
    }
}
