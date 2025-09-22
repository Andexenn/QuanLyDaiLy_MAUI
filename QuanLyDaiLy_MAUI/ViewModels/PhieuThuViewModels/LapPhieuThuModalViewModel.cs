using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuanLyDaiLy_MAUI.Services;
using System.Collections.ObjectModel;
using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.ViewModels.PhieuThuViewModels;

public partial class LapPhieuThuModalViewModel : BaseViewModel
{
    private Popup? _currentPopup;
    private readonly IDaiLyService _daiLyService;
    //private readonly IPhieuThuService _phieuThuService;
    public LapPhieuThuModalViewModel(IDaiLyService daiLyService)
	{
		_daiLyService = daiLyService;
        //_phieuThuService = phieuThuService;

        _ = LoadDataAsync();
    }

    [ObservableProperty]
    ObservableCollection<DaiLy> daiLies = [];
    [ObservableProperty]
    DaiLy? selectedDaiLy;
    [ObservableProperty]
    DateTime ngayThu = DateTime.Now;

    public void SetCurrentPopup(Popup popup) => _currentPopup = popup;

    [RelayCommand]
    private async Task CloseWindow()
    {
        if (_currentPopup != null)
            await _currentPopup.CloseAsync();
    }

    private async Task LoadDataAsync()
    {
        try
        {
            var dailies = await _daiLyService.GetAllDaiLyAsync();
            DaiLies = new ObservableCollection<DaiLy>(dailies);
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
        }
    }
}