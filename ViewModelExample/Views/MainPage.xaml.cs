using ViewModelExample.ViewModels;

namespace ViewModelExample.Views;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        MainVM vm = new MainVM();
    }

}