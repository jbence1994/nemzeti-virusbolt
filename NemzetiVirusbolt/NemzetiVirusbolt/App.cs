using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NemzetiVirusbolt.Views;

namespace NemzetiVirusbolt
{
    public static class App
    {
        [STAThread]
        public static void Main()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services => { services.AddScoped<MainWindow>(); })
                .Build();

            var mainWindow = host.Services.GetRequiredService<MainWindow>();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.Run(mainWindow);
        }
    }
}
