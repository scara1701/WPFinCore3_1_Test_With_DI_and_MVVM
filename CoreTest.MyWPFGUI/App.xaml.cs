using CoreTest.MyLib.Models;
using CoreTest.MyLib.Services;
using CoreTest.MyWPFGUI.Pages;
using CoreTest.MyWPFGUI.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace CoreTest.MyWPFGUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 


    public partial class App : Application
    {
        public readonly ServiceProvider _serviceProvider;

        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private void ConfigureServices(IServiceCollection serviceCollection)
        {
            NavigationService navigationService = new NavigationService();
            navigationService.NavigateEvent += NavigationService_NavigateEvent;
            serviceCollection.AddSingleton<IGetNumberService>(provider => new GetNumberService(52));
            serviceCollection.AddSingleton<INavigationService>(provider => navigationService);
            serviceCollection.AddSingleton<MainWindow>();
            serviceCollection.AddSingleton<MainPage>();
            serviceCollection.AddSingleton<DetailsPage>();
        }

        private void NavigationService_NavigateEvent(object sender, NavigateEventArgs e)
        {
            var MainWindow = _serviceProvider.GetService<MainWindow>();
            switch (e.Page)
            {
                case ApplicationPage.DetailsPage:
                    MainWindow.Navigate(_serviceProvider.GetService<DetailsPage>());
                    break;
                case ApplicationPage.MainPage:
                    MainWindow.Navigate(_serviceProvider.GetService<MainPage>());
                    break;
                default:
                    break;
            }
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var MainWindow = _serviceProvider.GetService<MainWindow>();
            //Toon venster
            MainWindow.Show();
            //Laad de mainpage, automatische injectie voor vereiste services (nav + getnumber)
            MainWindow.Navigate(_serviceProvider.GetService<MainPage>());
        }
    }
}
