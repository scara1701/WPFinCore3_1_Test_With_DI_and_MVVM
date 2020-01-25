using CoreTest.MyLib.Models;
using CoreTest.MyLib.Services;

namespace CoreTest.MyLib.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        IGetNumberService _getNumberService;
        INavigationService _navigationService;
        public MainViewModel(IGetNumberService getNumberService, INavigationService navigationService)
        {
            _getNumberService = getNumberService;
            _navigationService = navigationService;
            GoToDetailsCommand = new RelayCommand(() => GoToDetails());
        }

        private void GoToDetails()
        {
            _navigationService.Navigate(ApplicationPage.DetailsPage);
        }

        public int CurrentNumber
        {
            get { return _getNumberService.GetNumber(); }
        }

        public RelayCommand GoToDetailsCommand { get; set; }
    }
}
