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
    private readonly IPhieuThuService _phieuThuService;
    public LapPhieuThuModalViewModel(IDaiLyService daiLyService, IPhieuThuService phieuThuService)
    {
        _daiLyService = daiLyService;
        _phieuThuService = phieuThuService;

        _ = LoadDataAsync();
    }

    [ObservableProperty]
    ObservableCollection<DaiLy> daiLies = [];
    [ObservableProperty]
    DaiLy? selectedDaiLy;
    [ObservableProperty]
    DateTime ngayThu = DateTime.Now;
    [ObservableProperty]
    double soTienThu;

    public void SetCurrentPopup(Popup popup) => _currentPopup = popup;

    [RelayCommand]
    private async Task CloseWindow()
    {
        if (_currentPopup != null)
            await _currentPopup.CloseAsync();
    }

    private async Task LoadDataAsync()
    {
        IsLoading = true;
        await Task.Yield();
        try
        {
            var dailies = await _daiLyService.GetAllDaiLyAsync();
            DaiLies = new ObservableCollection<DaiLy>(dailies);
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
        }
        finally
        {
            await Task.Yield();
            IsLoading = false;
        }
    }

    [RelayCommand]
    void LapPhieuThu()
    {
        if (SoTienThu < 0)
            return;
        if(SelectedDaiLy == null)
        {
            Shell.Current.DisplayAlert("Lỗi", "Vui lòng chọn đại lý.", "OK");
            return;
        }
        if(SoTienThu > SelectedDaiLy.NoDaiLy) SoTienThu = SelectedDaiLy.NoDaiLy;
        SelectedDaiLy.NoDaiLy -= SoTienThu;
        _ = _daiLyService.UpdateNoDaiLy(SelectedDaiLy.MaDaiLy, SelectedDaiLy.NoDaiLy);
        Shell.Current.DisplayAlert("Thành công", "Lập phiếu thu thành công.", "OK");
    }
}