using QuanLyDaiLy_MAUI.Data;
using QuanLyDaiLy_MAUI.ViewModels;
using System.Threading.Tasks;

namespace QuanLyDaiLy_MAUI;

public partial class MainPage : ContentPage
{
    //private readonly AddAgentViewModel _addAgentViewModel;
    public MainPage(MainPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
        //_addAgentViewModel = new AddAgentViewModel(new DataContext());
    }

    //protected override async void OnAppearing()
    //{
    //    base.OnAppearing();
    //    await Shell.Current.DisplayAlert("Thong báo", "Ứng dụng đang trong giai đoạn phát triển. Mọi lỗi phát sinh vui lòng liên hệ tác giả qua email:", "OK");
    //    await _addAgentViewModel.LoadAgentAsync();
    //}
}
