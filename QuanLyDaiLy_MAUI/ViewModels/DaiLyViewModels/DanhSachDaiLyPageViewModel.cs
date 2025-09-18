using CommunityToolkit.Maui.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuanLyDaiLy_MAUI.Models;
using QuanLyDaiLy_MAUI.Services;
using QuanLyDaiLy_MAUI.ViewModels;
using QuanLyDaiLy_MAUI.Views.DaiLyViews;
using QuanLyDaiLy_MAUI.ViewModels.PhieuXuatViewModels;
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
	[ObservableProperty]
	//[NotifyPropertyChangedFor(nameof(BeforePage))]
	//[NotifyPropertyChangedFor(nameof(NextPage))]
	private int currentPage = 1;
	[ObservableProperty]
	private int beforePage = 0;
	[ObservableProperty]
	private int nextPage = 2;
	[ObservableProperty]
	private ObservableCollection<DaiLy> displayDaiLies = [];

    public async Task LoadDaiLyAsync()
	{
		IsLoading = true;
		await Task.Yield();
		try
		{
            await Task.Run(async () =>
            {
                var dailies = await _daiLyService.GetAllDaiLyAsync();

                // Update the collection on the UI thread
				DaiLies = new ObservableCollection<DaiLy>(dailies);
				DisplayDaiLies = new ObservableCollection<DaiLy>(DaiLies.Skip((CurrentPage - 1) * 20).Take(20));
                //MainThread.BeginInvokeOnMainThread(() =>
                //{
                //});
            });

        }
		catch (Exception ex)
		{
			await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
		}
		finally
		{
			IsLoading = false;
			await Task.Yield();
        }
	}

    [RelayCommand]
    private void LoadCommand() => _ = LoadDaiLyButton();

	[RelayCommand]
    [Obsolete]
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
				//await 
            }

        }
		catch (Exception ex)
		{
			await Shell.Current.DisplayAlert("Error 🐞", ex.Message, "OK");
		}
	}

	[RelayCommand]
    [Obsolete]
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

	[RelayCommand]
	private async Task NextButton()
	{
		try
		{
			if (CurrentPage == Math.Ceiling((double)DaiLies.Count / 20) - 1)
				NextPage = -1;
			if (CurrentPage == Math.Ceiling((double)DaiLies.Count / 20))
			{
				NextPage = 0;
                DisplayDaiLies = new ObservableCollection<DaiLy>(DaiLies.Skip((CurrentPage - 1) * 20).Take(20));
                return;
			}
			CurrentPage++;
			BeforePage++;
			NextPage++;
			DisplayDaiLies = new ObservableCollection<DaiLy>( DaiLies.Skip((CurrentPage - 1) * 20).Take(20));
		}
		catch (Exception ex)
		{
			await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
		}
	}

	[RelayCommand]
	private async Task BeforeButton()
	{
		try
		{
			if (CurrentPage == 1)
				return;
			if(NextPage == 0)
				NextPage = CurrentPage + 1;
            CurrentPage--;
			BeforePage--;
			NextPage--;
            DisplayDaiLies = new ObservableCollection<DaiLy>(DaiLies.Skip((CurrentPage - 1) * 20).Take(20));
        }
		catch (Exception ex)
		{
			await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
		}
	}

	[RelayCommand]
	private async Task GoToTraCuuDaiLyAsync()
	{
		await Shell.Current.GoToAsync(nameof(TraCuuDaiLyPage));
	}
}