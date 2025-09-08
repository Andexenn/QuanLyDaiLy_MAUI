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
    ObservableCollection<MatHang> matHangs = [];
    [ObservableProperty]
    MatHang? selectedMatHang1;
    [ObservableProperty]
    MatHang? selectedMatHang2;
    [ObservableProperty]
    MatHang? selectedMatHang3;
    [ObservableProperty]
    MatHang? selectedMatHang4;
    [ObservableProperty]
    ObservableCollection<(int SoLuongXuat, double DonGiaXuat)> soLuongDonGiaXuats = [];
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(GiaXuat1))]
    [NotifyPropertyChangedFor(nameof(TongTien))]
    int soLuongXuat1;
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(GiaXuat1))]
    [NotifyPropertyChangedFor(nameof(TongTien))]
    double donGiaXuat1;
    public double GiaXuat1 => SoLuongXuat1 * DonGiaXuat1;
    public double TongTien => GiaXuat1;

    partial void OnSoLuongXuat1Changed(int oldValue, int newValue)
    {
        if(newValue < 0)
        {
            Shell.Current.DisplayAlert("Lỗi", "Số lượng xuất không được âm.", "OK");
            SoLuongXuat1 = 0;
        }
        else if(newValue > SelectedMatHang1?.SoLuongTon)
        {
            Shell.Current.DisplayAlert("Lỗi", "Số lượng xuất không được nhiều hơn số lượng tồn", "OK");
            SoLuongXuat1 = 0;
        }
    }

    partial void OnDonGiaXuat1Changed(double oldValue, double newValue)
    {
        if(newValue < 0)
        {
            Shell.Current.DisplayAlert("Lỗi", "Đơn giá xuất không được âm.", "OK");
            DonGiaXuat1 = 0;
        }
    }

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

    [RelayCommand]
    async Task LapPhieuXuat()
    {
        try
        {
            IsLoading = true;
            if (!await ValidateInput())
                return;

            var phieuXuat = new PhieuXuat 
            { 
                MaPhieuXuat = MaPhieuXuat,
                NgayLapPhieu = NgayLapPhieu,
                MaDaiLy = SelectedDaiLy!.MaDaiLy,
                TongTriGia = TongTien
            };

            await _phieuXuatService.AddPhieuXuatAsync(phieuXuat);
            await Shell.Current.DisplayAlert("Thành công ⭐", "Lập phiếu xuất thành công", "OK");
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

    async Task<bool> ValidateInput()
    {
        if(SelectedDaiLy == null)
        {
            await Shell.Current.DisplayAlert("Lỗi", "Vui lòng chọn đại lý.", "OK");
            return false;
        }
        else if(SelectedMatHang1 == null && SoLuongXuat1 > 0)
        {
            await Shell.Current.DisplayAlert("Lỗi", "Vui lòng chọn mặt hàng 1.", "OK");
            return false;
        }
        return true;
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