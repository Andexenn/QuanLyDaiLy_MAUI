using QuanLyDaiLy_MAUI.ViewModels;
using QuanLyDaiLy_MAUI.ViewModels.DaiLyViewModels;
namespace QuanLyDaiLy_MAUI.Views.DaiLyViews;

public partial class DanhSachDaiLyPage : ContentPage
{
	public DanhSachDaiLyPage(DanhSachDaiLyPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}