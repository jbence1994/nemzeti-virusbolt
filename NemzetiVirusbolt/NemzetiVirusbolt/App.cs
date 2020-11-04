using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NemzetiVirusbolt.Persistence;
using NemzetiVirusbolt.Services;
using NemzetiVirusbolt.Views;

namespace NemzetiVirusbolt
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
                        options.UseSqlite(configuration.GetConnectionString("Default")));

                    services.AddScoped<IProductRepository, ProductRepository>();
                    services.AddScoped<IStockRepository, StockRepository>();
                    services.AddScoped<ISupplierRepository, SupplierRepository>();
                    services.AddScoped<IUnitOfWork, UnitOfWork>();
                    services.AddScoped<IUserRepository, UserRepository>();

                    services.AddScoped<MainWindow>();
                })
                .Build();

            var mainWindow = host.Services.GetRequiredService<MainWindow>();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.Run(mainWindow);
        }
    }
}
