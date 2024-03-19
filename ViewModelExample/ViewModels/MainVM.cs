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
        private DelegateCommand contadorCommand;
        private string buttonText = "Click me!";
        private int clickCount = 0;
        #endregion

        #region Properties
        public DelegateCommand ContadorCommand
        {
            get
            {
                return contadorCommand;
            }
        }
        public string ButtonText
        {
            get
            {
                return buttonText;
            }
        }
        private void contadorCommand_execute()
        {
            clickCount++;
            if (clickCount == 1)
                buttonText = $"Clicked {clickCount} time";
            else
                buttonText = $"Clicked {clickCount} times";
            NotifyPropertyChanged("ButtonText");
        }
        #endregion

        #region Constructor
        public MainVM()
        {
            contadorCommand = new DelegateCommand(contadorCommand_execute);
        }
        #endregion

        #region Methods
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