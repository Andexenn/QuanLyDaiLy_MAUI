using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuanLyDaiLy_MAUI.Services;
using System.Collections.ObjectModel;
using QuanLyDaiLy_MAUI.Models;
using System.Diagnostics.Metrics;

namespace QuanLyDaiLy_MAUI.ViewModels.PhieuXuatViewModels;

public partial class MatHangXuat : ObservableObject
{
    [ObservableProperty]
    int soThuTu;
    [ObservableProperty]
    private MatHang matHang;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(GiaXuat))]
    private int soLuongXuat;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(GiaXuat))]
    private double donGiaXuat;

    public double GiaXuat => SoLuongXuat * DonGiaXuat;

    public MatHangXuat(int soThuTu = 1, MatHang matHang = null!, int soLuongXuat = 0, double donGiaXuat = 0)
    {
        this.MatHang = matHang;
        SoLuongXuat = soLuongXuat;
        DonGiaXuat = donGiaXuat;
        SoThuTu = soThuTu;
    }
    partial void OnSoLuongXuatChanged(int oldValue, int newValue)
    {
        if (newValue < 0)
        {
            Shell.Current.DisplayAlert("Lỗi", "Số lượng xuất không được âm.", "OK");
            SoLuongXuat = 0;
        }
        else if (newValue > MatHang?.SoLuongTon)
        {
            Shell.Current.DisplayAlert("Lỗi", "Số lượng xuất không được nhiều hơn số lượng tồn", "OK");
            SoLuongXuat = 0;
        }
    }

    partial void OnDonGiaXuatChanged(double oldValue, double newValue)
    {
        if (newValue < 0)
        {
            Shell.Current.DisplayAlert("Lỗi", "Đơn giá xuất không được âm.", "OK");
            DonGiaXuat = 0;
        }
    }
}

public partial class LapPhieuXuatModalViewModel : BaseViewModel
{
    private readonly IDaiLyService _daiLyService;
    private readonly IPhieuXuatService _phieuXuatService;
    private readonly ILoaiDaiLyService _loaiDaiLyService;
    private readonly IQuanService _quanService;
    private readonly IThamSoService _thamSoService;
    private readonly IMatHangService _matHangService;

    private Popup? _currentPopup;

    [ObservableProperty]
    private int maPhieuXuat;

    [ObservableProperty]
    private DateTime ngayLapPhieu = DateTime.Now;

    [ObservableProperty]
    private ObservableCollection<DaiLy> daiLies = [];

    [ObservableProperty]
    private DaiLy? selectedDaiLy;

    [ObservableProperty]
    private ObservableCollection<MatHang> matHangs = [];

    [ObservableProperty]
    public double tongTien;

    [ObservableProperty]
    private ObservableCollection<MatHangXuat> matHangXuats = [];

    public LapPhieuXuatModalViewModel(IDaiLyService daiLyService, IPhieuXuatService phieuXuatService, ILoaiDaiLyService loaiDaiLyService, IQuanService quanService, IThamSoService thamSoService, IMatHangService matHangService)
    {
        _daiLyService = daiLyService;
        _phieuXuatService = phieuXuatService;
        _loaiDaiLyService = loaiDaiLyService;
        _quanService = quanService;
        _thamSoService = thamSoService;
        _matHangService = matHangService;

        MatHangXuats.CollectionChanged += MatHangXuats_CollectionChanged;

        _ = LoadDataAsync();
    }

    private void MatHangXuats_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
    {
        if (e.NewItems != null)
        {
            foreach (MatHangXuat newItem in e.NewItems)
            {
                newItem.PropertyChanged += MatHangXuat_PropertyChanged;
            }
        }
        if (e.OldItems != null)
        {
            foreach (MatHangXuat oldItem in e.OldItems)
            {
                oldItem.PropertyChanged -= MatHangXuat_PropertyChanged;
            }
        }
        CalTongTien();
    }

    private void MatHangXuat_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(MatHangXuat.GiaXuat))
        {
            CalTongTien();
        }
    }

    private void CalTongTien()
    {
        TongTien = MatHangXuats.Sum(mh => mh.GiaXuat);
    }

    private async Task LoadDataAsync()
    {
        MaPhieuXuat = await _phieuXuatService.GetNextAvailableIdAsync();
        NgayLapPhieu = DateTime.Now;

        IsLoading = true;
        await Task.Yield();
        try
        {
            await Task.Run(async () =>
            {
                await LoadComboBoxData();

                MatHangXuats.Clear();

            });
            for (int i = 0; i < MatHangs.Count; ++i)
                MatHangXuats.Add(new MatHangXuat(i + 1));
        }
        catch(Exception ex)
        {
            await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
        }
        finally
        {
            IsLoading = false;
            await Task.Yield();
        }

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
            UpdateSoLuongTonVaNoDaiLy();
            await Shell.Current.DisplayAlert("Thành công ⭐", "Lập phiếu xuất thành công", "OK");
            //await CloseWindow();
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

    void UpdateSoLuongTonVaNoDaiLy()
    {
        foreach(var mhx in MatHangXuats)
            mhx.MatHang.SoLuongTon -= mhx.SoLuongXuat;
        
        SelectedDaiLy!.NoDaiLy += TongTien;
    }

    async Task<bool> ValidateInput()
    {
        if(SelectedDaiLy == null)
        {
            await Shell.Current.DisplayAlert("Lỗi", "Vui lòng chọn đại lý.", "OK");
            return false;
        }
        else if (MatHangXuats[0].MatHang == null && MatHangXuats[0].SoLuongXuat > 0)
        {
            await Shell.Current.DisplayAlert("Lỗi", "Vui lòng chọn mặt hàng 1.", "OK");
            return false;
        }
        else if (MatHangXuats[0].SoLuongXuat == 0 || MatHangXuats[0].DonGiaXuat == 0)
        {
            await Shell.Current.DisplayAlert("Lỗi", "Vui lòng điền số khác 0", "OK");
            return false;
        }
        else if(SelectedDaiLy.NoDaiLy + TongTien > (SelectedDaiLy.LoaiDaiLy?.NoToiDa ?? 0))
        {
            await Shell.Current.DisplayAlert("Lỗi", "Tổng nợ đại lý vượt quá hạn mức cho phép.", "OK");
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

    [RelayCommand]
    private async Task NewPhieuXuat()
    {
        try
        {
            await LoadDataAsync();
        }
        catch(Exception ex)
        {
            await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
        }
    }
}