using QuanLyDaiLy_MAUI.ViewModels;

namespace QuanLyDaiLy_MAUI;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
