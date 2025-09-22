using CommunityToolkit.Mvvm.Input;

namespace QuanLyDaiLy_MAUI.ViewModels.DaiLyViewModels;

public partial class LapBaoCaoDoanhSoTheoThangPageViewModel : BaseViewModel
{
	public LapBaoCaoDoanhSoTheoThangPageViewModel()
	{
		
	}

	[RelayCommand]
	async Task CloseWindow()
	{
		await Shell.Current.GoToAsync("..");
    }
}