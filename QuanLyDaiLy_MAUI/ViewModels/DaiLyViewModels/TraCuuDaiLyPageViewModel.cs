using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace QuanLyDaiLy_MAUI.ViewModels.DaiLyViewModels;

public partial class TraCuuDaiLyPageViewModel : ObservableObject
{
	public TraCuuDaiLyPageViewModel()
	{
		
	}

	[RelayCommand]
	private async Task GoBack()
	{
		await Shell.Current.GoToAsync("..");
    }
}