using System;
using System.ComponentModel;
using System.Windows.Input;

namespace CoreTest.MyLib.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The event that is fired when any child property changes its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        /// Call this to fire a <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }

    public class RelayCommand : ICommand
    {
        #region Private Members
        /// <summary>
        /// The action to run
        /// </summary>
        private Action mAction;
        #endregion
        #region Public Events
        /// <summary>
        /// The event thats fired when the <see cref="CanExecute(object)"/> value has changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };
        #endregion
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public RelayCommand(Action action)
        {
            mAction = action;
        }

        #endregion
        #region Command Methods
        /// <summary>
        /// A relay command can always execute
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }
        /// <summary>
        /// Executes the commands Action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            mAction();
        }
        #endregion
    }

}
