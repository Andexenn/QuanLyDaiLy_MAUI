using CommunityToolkit.Maui.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuanLyDaiLy_MAUI.Models;
using QuanLyDaiLy_MAUI.Services;
using QuanLyDaiLy_MAUI.ViewModels;
using QuanLyDaiLy_MAUI.Views.DaiLyViews;
using System.Collections.ObjectModel;


namespace QuanLyDaiLy_MAUI.ViewModels.DaiLyViewModels;

public partial class DanhSachDaiLyPageViewModel : BaseViewModel
{
	private readonly IDaiLyService _daiLyService;
	private readonly IServiceProvider _serviceProvider;

    public DanhSachDaiLyPageViewModel(IDaiLyService daiLyService, IServiceProvider serviceProvider) 
	{
		_daiLyService = daiLyService;
		_serviceProvider = serviceProvider;
		Title = "Danh Sách Đại Lý";
		_ = LoadDaiLyAsync();
    }

	[ObservableProperty]
	private ObservableCollection<DaiLy> daiLies = [];

	public async Task LoadDaiLyAsync()
	{
		IsLoading = true;
		try
		{
			DaiLies = new ObservableCollection<DaiLy>(await _daiLyService.GetAllDaiLyAsync());
		}
		catch (Exception ex)
		{
			await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
		}
		finally
		{
			IsLoading = false;
        }
	}

    [RelayCommand]
    private void LoadCommand() => _ = LoadDaiLyButton();

	[RelayCommand]
	private async Task ThemDaiLyButton()
	{
		try
		{
			var themDaiLyModal = _serviceProvider.GetService<ThemDaiLyModalViewModel>();
			var themDaiLyPopup = new ThemDaiLyModal(themDaiLyModal!);

			var mainPage = Application.Current?.MainPage;
			if(mainPage != null)
			{
				await mainPage.ShowPopupAsync(themDaiLyPopup!);
            }

        }
		catch (Exception ex)
		{
			await Shell.Current.DisplayAlert("Error 🐞", ex.Message, "OK");
		}
	}

	[RelayCommand]
	private async Task LapPhieuXuatButton()
	{
		try
		{
			var lapPhieuXuatModal = _serviceProvider.GetService<LapPhieuXuatModalViewModel>();
			var lapPhieuXuatPopup = new LapPhieuXuatModal(lapPhieuXuatModal!);
			var mainPage = Application.Current?.MainPage;
			if (mainPage != null)
			{
				await mainPage.ShowPopupAsync(lapPhieuXuatPopup!);
			}
		}
		catch (Exception ex)
		{
			await Shell.Current.DisplayAlert("Error 🐞", ex.Message, "OK");
		}
	}

	[RelayCommand]
	private async Task LoadDaiLyButton()
	{
		await LoadDaiLyAsync();
		await Shell.Current.DisplayAlert("Thành công ⭐", "Tải trang thành công", "OK");
    }
}