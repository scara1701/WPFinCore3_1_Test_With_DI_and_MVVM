using CoreTest.MyLib.Models;
using CoreTest.MyLib.Services;
using System;
using System.Windows;

namespace CoreTest.MyWPFGUI.Services
{
    public class NavigationService : INavigationService
    {
        public void GoBack()
        {
            ((MainWindow)Application.Current.MainWindow).GoBack();
        }

        public void Navigate(ApplicationPage sourcePage)
        {
            NavigateEventArgs args = new NavigateEventArgs();
            args.Page = sourcePage;
            OnNavigate(args);
        }


        //Event handler created in App.xaml.cs, used for navigating with serviceprovider
        public event EventHandler<NavigateEventArgs> NavigateEvent;

        protected virtual void OnNavigate(NavigateEventArgs e)
        {
            EventHandler<NavigateEventArgs> handler = NavigateEvent;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }

     public class NavigateEventArgs : EventArgs
    {
        public ApplicationPage Page { get; set; }
    }
}
