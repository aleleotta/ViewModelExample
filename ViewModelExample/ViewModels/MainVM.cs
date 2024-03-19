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
        private DelegateCommand clickButton;
        private string buttonText;
        private int clickCount = 0;
        #endregion

        #region Properties
        public DelegateCommand ClickButton
        {
            get
            {
                return clickButton;
            }
        }
        public string ButtonText
        {
            get
            {
                return buttonText;
            }
        }
        private void click_execute()
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
            DelegateCommand clickButton = new DelegateCommand(click_execute);
            buttonText = "Click Me!";
            NotifyPropertyChanged("ButtonText");
        }
        #endregion

        #region Methods
        #endregion

        #region ViewModel
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName">The name of the changed property</param>
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}