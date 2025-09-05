using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using QuanLyDaiLy_MAUI.Models;
using QuanLyDaiLy_MAUI.Services;
using System.Collections.ObjectModel;

namespace QuanLyDaiLy_MAUI.ViewModels.DaiLyViewModels;

public partial class LapPhieuXuatModalViewModel : BaseViewModel
{
	private Popup? _currentPopup;
    public LapPhieuXuatModalViewModel()
    {	
	}

    public void SetCurrentPopup(Popup popup) => _currentPopup = popup;


    [RelayCommand]
    private async Task CloseWindow()
    {
        try
        {
            if (_currentPopup != null)
            {
                await _currentPopup.CloseAsync();
            }
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
        }
    }
}