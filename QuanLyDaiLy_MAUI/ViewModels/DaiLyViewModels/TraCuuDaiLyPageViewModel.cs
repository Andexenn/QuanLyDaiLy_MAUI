using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuanLyDaiLy_MAUI.Services;
using QuanLyDaiLy_MAUI.Models;
using System.Collections.ObjectModel;

namespace QuanLyDaiLy_MAUI.ViewModels.DaiLyViewModels;

public partial class TraCuuDaiLyPageViewModel : BaseViewModel
{
	private readonly IDaiLyService _daiLyService;
	private readonly IMatHangService _matHangService;
	private readonly IQuanService _quanService;
	private readonly IDonViTinhService _donViTinhService;
	private readonly ILoaiDaiLyService _loaiDaiLyService;

    public TraCuuDaiLyPageViewModel(IDaiLyService daiLyService, IMatHangService matHangService, IQuanService quanService, IDonViTinhService donViTinhService, ILoaiDaiLyService loaiDaiLyService)
	{
		_daiLyService = daiLyService;
		_matHangService = matHangService;
		_quanService = quanService;
		_donViTinhService = donViTinhService;
		_loaiDaiLyService = loaiDaiLyService;

		_ = LoadDataAsync();
    }

	[ObservableProperty]
	ObservableCollection<MatHang> matHangs = [];
	[ObservableProperty]
    ObservableCollection<Quan> quans = [];
	[ObservableProperty]
    ObservableCollection<DonViTinh> donViTinhs = [];
	[ObservableProperty]
    ObservableCollection<LoaiDaiLy> loaiDaiLies = [];
	[ObservableProperty]
	ObservableCollection<DaiLy> daiLies = [];

    [ObservableProperty]
	private LoaiDaiLy? selectedLoaiDaiLy;
	[ObservableProperty]
	private Quan? selectedQuan;
	[ObservableProperty]
	private MatHang? selectedMatHang;
	[ObservableProperty]
	private DonViTinh? selectedDonViTinh;




    [RelayCommand]
	private async Task GoBack()
	{
		await Shell.Current.GoToAsync("..");
    }

	async Task LoadDataAsync()
	{
		IsLoading = true;
		await Task.Yield();
        try
		{
            _ = Task.Run(async () =>
            {
                var matHangs = await _matHangService.GetAllMatHangAsync();
                var quans = await _quanService.GetAllQuanAsync();
                var donViTinhs = await _donViTinhService.GetAllDonViTinhAsync();
                var loaiDaiLies = await _loaiDaiLyService.GetAllLoaiDaiLyAsync(); 
				var daiLies = await _daiLyService.GetAllDaiLyAsync();

				DaiLies = new ObservableCollection<DaiLy>(daiLies);
                MatHangs = new ObservableCollection<MatHang>(matHangs);
                Quans = new ObservableCollection<Quan>(quans);
                DonViTinhs = new ObservableCollection<DonViTinh>(donViTinhs);
                LoaiDaiLies = new ObservableCollection<LoaiDaiLy>(loaiDaiLies);
            });
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
}