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
        public MainPage(IGetNumberService getNumberService, INavigationService navigationService)
        {
            InitializeComponent();
            this.DataContext = new MainViewModel(getNumberService, navigationService);
        }
    }
}
