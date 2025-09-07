using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuanLyDaiLy_MAUI.Services;
using System.Collections.ObjectModel;
using QuanLyDaiLy_MAUI.Models;
using System.Diagnostics.Metrics;

namespace QuanLyDaiLy_MAUI.ViewModels.PhieuXuatViewModels;
public partial class LapPhieuXuatModalViewModel : BaseViewModel
{
    private readonly IDaiLyService _daiLyService;
    private readonly IPhieuXuatService _phieuXuatService;
    private readonly ILoaiDaiLyService _loaiDaiLyService;
    private readonly IQuanService _quanService;
    private readonly IThamSoService _thamSoService;
    private readonly IMatHangService _matHangService;

    private Popup? _currentPopup;

    public LapPhieuXuatModalViewModel(IDaiLyService daiLyService, IPhieuXuatService phieuXuatService, ILoaiDaiLyService loaiDaiLyService, IQuanService quanService, IThamSoService thamSoService, IMatHangService matHangService)
    {	
        _daiLyService = daiLyService;
        _phieuXuatService = phieuXuatService;
        _loaiDaiLyService = loaiDaiLyService;
        _quanService = quanService;
        _thamSoService = thamSoService;
        _matHangService = matHangService;

        _ = LoadDataAsync();
    }

    [ObservableProperty]
    int maPhieuXuat;
    [ObservableProperty]
    DateTime ngayLapPhieu = DateTime.Now;
    [ObservableProperty]
    ObservableCollection<DaiLy> daiLies = [];
    [ObservableProperty]
    DaiLy? selectedDaiLy;
    [ObservableProperty]
    double noDaiLy = 0;
    [ObservableProperty]
    double noToiDa = 0;
    [ObservableProperty]
    ObservableCollection<MatHang> matHangs = [];
    [ObservableProperty]
    MatHang? selectedMatHang1;

    private async Task LoadDataAsync()
    {
        MaPhieuXuat = await _phieuXuatService.GetNextAvailableIdAsync();
        NgayLapPhieu = DateTime.Now;
        
        _ = LoadComboBoxData();
    }

    private async Task LoadComboBoxData()
    {
        try
        {
            var dailies = await _daiLyService.GetAllDaiLyAsync();
            DaiLies = new ObservableCollection<DaiLy>(dailies);
            var mathangs = await _matHangService.GetAllMatHangAsync();
            MatHangs = new ObservableCollection<MatHang>(mathangs);

            if (DaiLies.Count > 0)
                SelectedDaiLy = DaiLies[0];

            
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
        }
    }

    private async Task UpdateNo()
    {
        if (SelectedDaiLy != null)
        {
            try
            {
                //var daily = await _daiLyService.GetDaiLyByTenAsync(SelectedDaiLy.TenDaiLy);
                //NoDaiLy = daily.NoDaiLy;
                NoDaiLy = SelectedDaiLy.NoDaiLy;
                NoToiDa = (SelectedDaiLy.MaLoaiDaiLy == 1 ? 200000 : 50);
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
            }
        }
        else
            NoDaiLy = NoToiDa = 0;

    }

    partial void OnSelectedDaiLyChanged(DaiLy? oldValue, DaiLy? newValue)
    {
        _ = UpdateNo();
    }

    private async Task UpdateMatHang()
    {
        if(SelectedMatHang1 != null)
        {
            try
            {

            }
            catch(Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
            }

        }
    }

    partial void OnSelectedMatHang1Changed(MatHang? oldValue, MatHang? newValue)
    {
        _ = UpdateMatHang();
        // Handle any additional logic when SelectedMatHang1 changes, if necessary
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