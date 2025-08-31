using CommunityToolkit.Maui.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuanLyDaiLy_MAUI.Views;
namespace QuanLyDaiLy_MAUI.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
	public MainPageViewModel()
	{
		
	}

	[RelayCommand]
	async Task OnTapClicked()
	{
		var popup = new AddAgent(new AddAgentViewModel());
		Application.Current.MainPage.ShowPopup(popup);
    }
}