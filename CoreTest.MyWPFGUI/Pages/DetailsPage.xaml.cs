using CoreTest.MyLib.Services;
using CoreTest.MyLib.ViewModels;
using System.Windows.Controls;

namespace CoreTest.MyWPFGUI.Pages
{
    /// <summary>
    /// Interaction logic for Details.xaml
    /// </summary>
    public partial class DetailsPage : Page
    {
        public DetailsPage(IGetNumberService getNumberService, INavigationService navigationService)
        {
            InitializeComponent();
            DataContext = new DetailsViewModel(getNumberService, navigationService);
        }
    }
}
