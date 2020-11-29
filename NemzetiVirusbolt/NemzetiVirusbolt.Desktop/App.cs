using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NemzetiVirusbolt.Core.Repositories;
using NemzetiVirusbolt.Desktop.Persistence;
using NemzetiVirusbolt.Desktop.Persistence.Repositories;
using NemzetiVirusbolt.Desktop.Services.Authentication;
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
                    services.AddDbContext<ApplicationDbContext>(options =>
                        options.UseMySQL(configuration.GetConnectionString("Default")));

                    services.AddScoped<IProductRepository, ProductRepository>();
                    services.AddScoped<IStockRepository, StockRepository>();

                    services.AddScoped<IAuthenticationService, AuthenticationService>();

                    services.AddScoped<LoginWindow>();
                    services.AddScoped<MainWindow>();
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
