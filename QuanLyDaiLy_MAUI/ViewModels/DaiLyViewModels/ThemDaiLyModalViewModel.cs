using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuanLyDaiLy_MAUI.Models;
using QuanLyDaiLy_MAUI.Services;
using System.Collections.ObjectModel;

namespace QuanLyDaiLy_MAUI.ViewModels.DaiLyViewModels;

public partial class ThemDaiLyModalViewModel : BaseViewModel
{
	private readonly IDaiLyService _daiLyService;
	private readonly IQuanService _quanService;
	private readonly ILoaiDaiLyService _loaiDaiLyService;
	private readonly IThamSoService _thamSoService;
	private Popup? _currentPopup;


    public ThemDaiLyModalViewModel(IDaiLyService daiLyService, IQuanService quanService, ILoaiDaiLyService loaiDaiLyService, IThamSoService thamSoService)
    {
		_daiLyService = daiLyService;
		_quanService = quanService;
		_loaiDaiLyService = loaiDaiLyService;
		_thamSoService = thamSoService;

		_ = LoadDataAsync();
    }

    [ObservableProperty]
	private int maDaiLy;
	[ObservableProperty]
	private string tenDaiLy = string.Empty;
	[ObservableProperty]
	private string diaChi = string.Empty;
	[ObservableProperty]
	private string soDienThoai = string.Empty;
	[ObservableProperty]
	private string email = string.Empty;
	[ObservableProperty]
	private DateTime ngayTiepNhan = DateTime.Now;
	[ObservableProperty]
	private ObservableCollection<LoaiDaiLy> loaiDaiLies = [];
	[ObservableProperty]
	private LoaiDaiLy? selectedLoaiDaiLy;
	[ObservableProperty]
	private ObservableCollection<Quan> quans = [];
	[ObservableProperty]
	private Quan? selectedQuan;
	[ObservableProperty]
	private int soLuongDaiLyHienCo = 0;
	[ObservableProperty]
	private int soLuongDaiLyToiDa = 0;

	private async Task LoadDataAsync()
	{
        NgayTiepNhan = DateTime.Now;
        MaDaiLy = await _daiLyService.GetNextAvailableIdAsync();

        _ = LoadComboBoxData();
    }

	private async Task LoadComboBoxData()
	{
		try
		{
			IsLoading = true;

			var loaiDaiLies = await _loaiDaiLyService.GetAllLoaiDaiLyAsync();
			var quans = await _quanService.GetAllQuanAsync();

            LoaiDaiLies = new ObservableCollection<LoaiDaiLy>(loaiDaiLies);
			Quans = new ObservableCollection<Quan>(quans);

			if(LoaiDaiLies.Count > 0)
				SelectedLoaiDaiLy = LoaiDaiLies[0];

			if(Quans.Count > 0)
				SelectedQuan = Quans[0];

			await LoadSoLuongDaiLyToiDa();
        }
		catch(Exception ex)
		{
			await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
        }
		finally
		{
			IsLoading = false;
        }
    }

	private async Task LoadSoLuongDaiLyToiDa()
	{
		try
		{
            var soLuongToiDaStr = await _thamSoService.GetThamSoAsync("SoLuongDaiLyToiDa");

            if (!string.IsNullOrEmpty(soLuongToiDaStr) && int.TryParse(soLuongToiDaStr, out int soLuongToiDa))
            {
                SoLuongDaiLyToiDa = soLuongToiDa;
            }
            else
            {
                SoLuongDaiLyToiDa = 50; 
            }
        }
		catch(Exception ex)
		{
			await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
		}
    }

    private async Task UpdateDaiLyCountsForSelectedQuan()
    {
        if (SelectedQuan != null)
        {
            try
            {
                var allDaiLies = await _daiLyService.GetAllDaiLyAsync();
                SoLuongDaiLyHienCo = allDaiLies.Count(dl => dl.MaQuan == SelectedQuan.MaQuan);
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
                SoLuongDaiLyHienCo = 0;
            }
        }
        else
        {
            SoLuongDaiLyHienCo = 0;
        }
    }

    partial void OnSelectedQuanChanged(Quan? value)
    {
        _ = UpdateDaiLyCountsForSelectedQuan();
    }

    [RelayCommand]
    private async Task TiepNhanDaiLy()
    {
        if (!await ValidateInput())
            return;

        try
        {
            IsLoading = true;

            var newDaiLy = new DaiLy
            {
                TenDaiLy = TenDaiLy,
                DiaChi = DiaChi,
                Email = Email,
                NgayTiepNhan = NgayTiepNhan,
                NoDaiLy = 0,
                SoDienThoai = SoDienThoai,
                MaLoaiDaiLy = SelectedLoaiDaiLy!.MaLoaiDaiLy,
                MaQuan = SelectedQuan!.MaQuan
            };

            await _daiLyService.AddDaiLyAsync(newDaiLy);

            await Shell.Current.DisplayAlert("Thành công ⭐", "Thêm đại lý thành công", "OK");

            
            await CloseWindow();
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
    private async Task DaiLyMoi()
    {
        TenDaiLy = string.Empty;
        SoDienThoai = string.Empty;
        Email = string.Empty;
        DiaChi = string.Empty;
        NgayTiepNhan = DateTime.Now;

        if (LoaiDaiLies.Any())
            SelectedLoaiDaiLy = LoaiDaiLies[0];

        if (Quans.Any())
        {
            SelectedQuan = Quans[0];
            await UpdateDaiLyCountsForSelectedQuan();
        }

        try
        {
            MaDaiLy = await _daiLyService.GetNextAvailableIdAsync();
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
        }
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

    private async Task<bool> ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(TenDaiLy))
        {
            await Shell.Current.DisplayAlert("Thông báo", "Vui lòng nhập tên đại lý", "OK");
            return false;
        }

        if (string.IsNullOrWhiteSpace(Email))
        {
            await Shell.Current.DisplayAlert("Thông báo", "Vui lòng nhập email", "OK");
            return false;
        }

        if (string.IsNullOrWhiteSpace(DiaChi))
        {
            await Shell.Current.DisplayAlert("Thông báo", "Vui lòng nhập địa chỉ", "OK");
            return false;
        }

        if (SelectedLoaiDaiLy == null)
        {
            await Shell.Current.DisplayAlert("Thông báo", "Vui lòng nhập loại đại lý", "OK");
            return false;
        }

        if (SelectedQuan == null)
        {
            await Shell.Current.DisplayAlert("Thông báo", "Vui lòng chọn quận", "OK");
            return false;
        }

        if (SoLuongDaiLyHienCo >= SoLuongDaiLyToiDa)
        {
            await Shell.Current.DisplayAlert("Thông báo", $"Không thể chọn thêm đại lý vào quận vì đã vượt quá số lượng tối đa, số lượng đại lý hiện tại: {SoLuongDaiLyHienCo}, số lượng đại lý tối đa: {SoLuongDaiLyToiDa}", "OK");
            return false;
        }

        return true;
    }
}