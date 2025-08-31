using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace QuanLyDaiLy_MAUI.ViewModels;

public partial class AddAgentViewModel : ObservableObject
{
	public AddAgentViewModel()
	{
	}

	[RelayCommand]
    async Task Announce()
	{
		await Shell.Current.DisplayAlert("Thông báo", "Thêm đại lý thành công!", "OK");
    }
}