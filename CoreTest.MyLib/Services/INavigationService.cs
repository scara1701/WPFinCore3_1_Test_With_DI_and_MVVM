using CoreTest.MyLib.Models;

namespace CoreTest.MyLib.Services
{
    public interface INavigationService
    {
        void Navigate(ApplicationPage sourcePage);
        void GoBack();
    }
}
