using QuanLyDaiLy_MAUI.Data;
using QuanLyDaiLy_MAUI.ViewModels;
using System.Threading.Tasks;

namespace QuanLyDaiLy_MAUI;

public partial class MainPage : ContentPage
{
    private readonly AddAgentViewModel _addAgentViewModel;
    public MainPage(MainPageViewModel vm, AddAgentViewModel addAgentViewModel)
    {
        InitializeComponent();
        BindingContext = vm;
        _addAgentViewModel = addAgentViewModel;

    }
}
