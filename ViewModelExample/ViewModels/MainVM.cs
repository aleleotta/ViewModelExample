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
        private int clickNum;
        #endregion

        #region Properties
        public DelegateCommand ClickButton { get { return clickButton; }}
        public void click_execute()
        {
            clickNum++;
        }
        #endregion

        #region Constructor
        public MainVM()
        {
            DelegateCommand clickButton = new DelegateCommand(click_execute);
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