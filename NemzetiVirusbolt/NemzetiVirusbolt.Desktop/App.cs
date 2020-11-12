using System;
using System.Windows.Forms;
using Autofac;
using NemzetiVirusbolt.Desktop.Persistence.Repositories;
using NemzetiVirusbolt.Desktop.Views;
using NemzetiVirusbolt.Desktop.Views.Components;

namespace NemzetiVirusbolt.Desktop
{
    public class App
    {
        private readonly MainWindow _mainWindow;

        public App(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
        }

        private static IContainer GetIocContainer()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<ProductRepository>().As<IProductRepository>();

            containerBuilder.RegisterType<App>().AsSelf();
            containerBuilder.RegisterType<CentralStockComponent>().AsSelf();
            containerBuilder.RegisterType<SearchComponent>().AsSelf();
            containerBuilder.RegisterType<StockComponent>().AsSelf();
            containerBuilder.RegisterType<LoginWindow>().AsSelf();
            containerBuilder.RegisterType<MainWindow>().AsSelf();

            return containerBuilder.Build();
        }

        private void Run()
        {
            Application.Run(_mainWindow);
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var scope = GetIocContainer().BeginLifetimeScope())
            {
                scope.Resolve<App>().Run();
            }
        }
    }
}
