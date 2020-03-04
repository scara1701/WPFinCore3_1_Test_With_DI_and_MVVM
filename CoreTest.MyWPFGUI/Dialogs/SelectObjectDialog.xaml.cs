using CoreTest.MyLib.ViewModels;
using System;
using System.Windows;

namespace CoreTest.MyWPFGUI.Dialogs
{
    /// <summary>
    /// Interaction logic for SelectObjectDialog.xaml
    /// </summary>
    public partial class SelectObjectDialog : Window
    {
        public SelectObjectDialog(SelectObjectViewModel selectObjectViewModel)
        {
            InitializeComponent();
            this.DataContext = selectObjectViewModel;
            selectObjectViewModel.CloseAction = new Action(() => this.Close());
        }
    }
}
