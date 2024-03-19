using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ViewModelExample.Utilities;

namespace ViewModelExample.ViewModels
{
    internal class MainVM : INotifyPropertyChanged
    {
        #region Attributes
        private DelegateCommand counterCommand;
        private string buttonText = "Click me!";
        private int clickCount = 0;
        #endregion

        #region Properties
        /// <summary>
        /// Returns the command to whatever button it is assigned to.
        /// </summary>
        public DelegateCommand ContadorCommand
        {
            get
            {
                return counterCommand;
            }
        }
        /// <summary>
        /// Returns the value of the current text on the button.
        /// </summary>
        public string ButtonText
        {
            get
            {
                return buttonText;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of MainVM().
        /// </summary>
        public MainVM()
        {
            counterCommand = new DelegateCommand(counterCommand_execute);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Updates the clickCount and notifies the property so the view updates the text within the button.
        /// </summary>
        private void counterCommand_execute()
        {
            clickCount++;
            if (clickCount == 1)
                buttonText = $"Clicked {clickCount} time";
            else
                buttonText = $"Clicked {clickCount} times";
            NotifyPropertyChanged("ButtonText");
        }
        #endregion

        #region ViewModel
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Notifies a view that a specific property has been changed.
        /// </summary>
        /// <param name="propertyName">The name of the changed property</param>
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}