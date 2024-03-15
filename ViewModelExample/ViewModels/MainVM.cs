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
        private Button button;
        private int clickCount;
        #endregion

        #region Properties
        public DelegateCommand ClickButton { get { return clickButton; }}
        public Button Button { get { return button; } }
        public void click_execute()
        {
            clickCount++;
            if (clickCount == 1)
                button.Text = $"Clicked {clickCount} time";
            else
                button.Text = $"Clicked {clickCount} times";

        }
        #endregion

        #region Constructor
        public MainVM()
        {
            DelegateCommand clickButton = new DelegateCommand(click_execute);
            button = new Button();
            button.Text = "Click me!";
        }
        #endregion

        #region Methods
        #endregion

        #region ViewModel
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}