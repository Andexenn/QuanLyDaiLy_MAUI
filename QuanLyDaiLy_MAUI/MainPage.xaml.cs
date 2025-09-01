using QuanLyDaiLy_MAUI.Data;
using QuanLyDaiLy_MAUI.ViewModels;
using System.Threading.Tasks;

namespace QuanLyDaiLy_MAUI;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
