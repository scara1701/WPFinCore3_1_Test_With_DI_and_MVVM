using CoreTest.MyLib.Models;

namespace CoreTest.MyLib.Services
{
    /// <summary>
    /// Interface for navigation commands in UI
    /// </summary>
    public interface INavigationService
    {
        void Navigate(ApplicationPage sourcePage);
        void GoBack();
    }
}
