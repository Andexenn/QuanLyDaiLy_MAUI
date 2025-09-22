using QuanLyDaiLy_MAUI.ViewModels.DaiLyViewModels;

namespace QuanLyDaiLy_MAUI.Views.DaiLyViews;

public partial class LapBaoCaoDoanhSoTheoThangPage : ContentPage
{
	public LapBaoCaoDoanhSoTheoThangPage(LapBaoCaoDoanhSoTheoThangPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}