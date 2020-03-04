using CoreTest.MyLib.Services;
using CoreTest.MyLib.ViewModels;
using System.Windows.Controls;

namespace CoreTest.MyWPFGUI.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        //Dependency injection at work
        public MainPage(IGetNumberService getNumberService, INavigationService navigationService, IDialogService dialogService)
        {
            InitializeComponent();
            this.DataContext = new MainViewModel(getNumberService, navigationService, dialogService);
        }
    }
}
