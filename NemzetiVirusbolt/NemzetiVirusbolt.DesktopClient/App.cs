using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NemzetiVirusbolt.Core;
using NemzetiVirusbolt.Core.Repositories;
using NemzetiVirusbolt.DesktopClient.Views;
using NemzetiVirusbolt.DesktopClient.Views.Components;
using NemzetiVirusbolt.Persistence;

namespace NemzetiVirusbolt.DesktopClient
{
    public static class App
    {
        private const string AppSettingsFile = "appsettings.json";
        private const string DefaultDatabaseConnectionName = "Default";

        [STAThread]
        public static void Main()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(path: AppSettingsFile, optional: true)
                .Build();

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddDbContext<ApplicationDbContext>(options =>
                        options.UseSqlite(configuration.GetConnectionString(DefaultDatabaseConnectionName)));

                    services.AddScoped<IProductRepository, ProductRepository>();
                    services.AddScoped<IStockRepository, StockRepository>();
                    services.AddScoped<ISupplierRepository, SupplierRepository>();
                    services.AddScoped<IUnitOfWork, UnitOfWork>();
                    services.AddScoped<IUserRepository, UserRepository>();

                    services.AddScoped<LoginWindow>();
                    services.AddScoped<MainWindow>();
                    services.AddScoped<AddProductComponent>();
                    services.AddScoped<SearchComponent>();
                    services.AddScoped<StockComponent>();

                })
                .Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(mainForm: host.Services.GetRequiredService<LoginWindow>());
            // TODO: amíg nem jövök rá loginnál miért omlik össze az Sqlie dll-je, addig a főablak indul el, hogy tudjátok tesztelni a UI-t...

            Application.Run(mainForm: host.Services.GetRequiredService<MainWindow>());
        }
    }
}
