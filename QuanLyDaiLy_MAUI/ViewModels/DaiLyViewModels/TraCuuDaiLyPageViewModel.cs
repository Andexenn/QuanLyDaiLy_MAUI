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
	private readonly IPhieuXuatService _phieuXuatService;
	private readonly ICTPhieuXuatService _ctPhieuXuatService;

    public TraCuuDaiLyPageViewModel(IDaiLyService daiLyService, IMatHangService matHangService, IQuanService quanService, IDonViTinhService donViTinhService, ILoaiDaiLyService loaiDaiLyService, ICTPhieuXuatService cTPhieuXuatService, IPhieuXuatService phieuXuatService)
	{
		_daiLyService = daiLyService;
		_matHangService = matHangService;
		_quanService = quanService;
		_donViTinhService = donViTinhService;
		_loaiDaiLyService = loaiDaiLyService;
		_ctPhieuXuatService = cTPhieuXuatService;
		_phieuXuatService = phieuXuatService;

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
	ObservableCollection<DaiLy> filteredDaiLies = [];

    [ObservableProperty]
	private LoaiDaiLy? selectedLoaiDaiLy;
	[ObservableProperty]
	private Quan? selectedQuan;
	[ObservableProperty]
	private MatHang? selectedMatHang;
	[ObservableProperty]
	private DonViTinh? selectedDonViTinh;
	[ObservableProperty]
	string maDaiLy = "";
	[ObservableProperty]
	string tenLoaiDaiLy = "";
	[ObservableProperty]
	string soDienThoai = "";
	[ObservableProperty]
	string diaChi = "";
	[ObservableProperty]
	string email = "";

	[ObservableProperty]
	DateTime ngayTiepNhanFrom = DateTime.Now.AddYears(-1);
	[ObservableProperty]
	DateTime ngayTiepNhanTo = DateTime.Now;
	[ObservableProperty]
	double noDaiLyFrom = 0;
	[ObservableProperty]
	double noDaiLyTo = 1000000000;
	[ObservableProperty]
	int maPhieuXuatFrom = 0;
	[ObservableProperty]
	int maPhieuXuatTo = 1000000;
	[ObservableProperty]
	DateTime ngayLapPhieuXuatFrom = DateTime.Now.AddYears(-1);
	[ObservableProperty]
	DateTime ngayLapPhieuXuatTo = DateTime.Now;
	[ObservableProperty]
	double tongTienPhieuXuatFrom = 0;
	[ObservableProperty]
	double tongTienPhieuXuatTo = 1000000000;
	[ObservableProperty]
	int soLuongMatHangXuatFrom = 0;
	[ObservableProperty]
	int soLuongMatHangXuatTo = 1000000;
	[ObservableProperty]
	double donGiaMatHangXuatFrom = 0;
	[ObservableProperty]
	double donGiaMatHangXuatTo = 1000000000;
	[ObservableProperty]
	double thanhTienMatHangXuatFrom = 0;
	[ObservableProperty]
	double thanhTienMatHangXuatTo = 1000000000;
	[ObservableProperty]
	int soLuongTonMatHangXuatFrom = 0;
	[ObservableProperty]
	int soLuongTonMatHangXuatTo = 1000000;

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

	[RelayCommand]
	async Task TraCuuDaiLy()
	{
		IsLoading = true;
		await Task.Yield();
		try
		{

		}
		catch(Exception ex)
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