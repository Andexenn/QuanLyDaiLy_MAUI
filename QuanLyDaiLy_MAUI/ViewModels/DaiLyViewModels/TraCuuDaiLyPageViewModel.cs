using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuanLyDaiLy_MAUI.Services;
using QuanLyDaiLy_MAUI.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;

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
	ObservableCollection<PhieuXuat> phieuXuats = [];
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
	string tenDaiLy = "";
	[ObservableProperty]
	string maDaiLy = "";
	[ObservableProperty]
	string soDienThoai = "";
	[ObservableProperty]
	string diaChi = "";
	[ObservableProperty]
	string email = "";

	[ObservableProperty]
	DateTime ngayTiepNhanFrom = DateTime.Now.AddYears(-50);
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
	DateTime ngayLapPhieuXuatFrom = DateTime.Now.AddYears(-50);
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
            var matHangs = await _matHangService.GetAllMatHangAsync();
            var quans = await _quanService.GetAllQuanAsync();
            var donViTinhs = await _donViTinhService.GetAllDonViTinhAsync();
            var loaiDaiLies = await _loaiDaiLyService.GetAllLoaiDaiLyAsync();
            var daiLies = await _daiLyService.GetAllDaiLyAsync();
            var phieuXuats = await _phieuXuatService.GetAllPhieuXuatAsync();

            DaiLies = new ObservableCollection<DaiLy>(daiLies);
            MatHangs = new ObservableCollection<MatHang>(matHangs);
            Quans = new ObservableCollection<Quan>(quans);
            DonViTinhs = new ObservableCollection<DonViTinh>(donViTinhs);
            LoaiDaiLies = new ObservableCollection<LoaiDaiLy>(loaiDaiLies);
            PhieuXuats = new ObservableCollection<PhieuXuat>(phieuXuats);
            //_ = Task.Run(async () =>
            //{
                
            //});
			Debug.WriteLine($"{DaiLies.Count}");
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
			FilterDaiLies();
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

	private void FilterDaiLies()
	{
		var query = DaiLies.AsEnumerable();
		if(!string.IsNullOrWhiteSpace(TenDaiLy))
		{
			query = query.Where(d => d.TenDaiLy.Contains(TenDaiLy, StringComparison.OrdinalIgnoreCase));
		}
		if (!string.IsNullOrWhiteSpace(MaDaiLy) && int.TryParse(MaDaiLy, out int maDaiLyValue))
		{
			query = query.Where(d => d.MaDaiLy == maDaiLyValue);
		}
		if (!string.IsNullOrWhiteSpace(SoDienThoai))
		{
			query = query.Where(d => d.SoDienThoai.Contains(SoDienThoai, StringComparison.OrdinalIgnoreCase));
		}
		if (!string.IsNullOrWhiteSpace(DiaChi))
		{
			query = query.Where(d => d.DiaChi.Contains(DiaChi, StringComparison.OrdinalIgnoreCase));
		}
		if (!string.IsNullOrWhiteSpace(Email))
		{
			query = query.Where(d => d.Email.Contains(Email, StringComparison.OrdinalIgnoreCase));
		}
		if (SelectedLoaiDaiLy != null)
		{
			query = query.Where(d => d.MaLoaiDaiLy == SelectedLoaiDaiLy.MaLoaiDaiLy);
		}
		if (SelectedQuan != null)
		{
			query = query.Where(d => d.MaQuan == SelectedQuan.MaQuan);
		}
		query = query.Where(d => d.NgayTiepNhan >= NgayTiepNhanFrom && d.NgayTiepNhan <= NgayTiepNhanTo);
		query = query.Where(d => d.NoDaiLy >= NoDaiLyFrom && d.NoDaiLy <= NoDaiLyTo);
		query = query.Where(d => d.PhieuXuats.Any(px => px.MaPhieuXuat >= MaPhieuXuatFrom && px.MaPhieuXuat <= MaPhieuXuatTo));
		query = query.Where(d => d.PhieuXuats.Any(px => px.NgayLapPhieu >= NgayLapPhieuXuatFrom && px.NgayLapPhieu <= NgayLapPhieuXuatTo));
		query = query.Where(d => d.PhieuXuats.Any(px => px.TongTriGia >= TongTienPhieuXuatFrom && px.TongTriGia <= TongTienPhieuXuatTo));
		//if(SelectedMatHang != null)
		//{
		//	query = query.Where(d => d.PhieuXuats.Any(px => px.CTPhieuXuats.Any(ctpx => ctpx.MaMatHang == SelectedMatHang.MaMatHang)));
		//	query = query.Where(d => d.PhieuXuats.Any(px => px.CTPhieuXuats.Any(ctpx => ctpx.MaMatHang == SelectedMatHang.MaMatHang && ctpx.SoLuongXuat >= SoLuongMatHangXuatFrom && ctpx.SoLuongXuat <= SoLuongMatHangXuatTo)));
		//	query = query.Where(d => d.PhieuXuats.Any(px => px.CTPhieuXuats.Any(ctpx => ctpx.MaMatHang == SelectedMatHang.MaMatHang && ctpx.DonGiaXuat >= DonGiaMatHangXuatFrom && ctpx.DonGiaXuat <= DonGiaMatHangXuatTo)));
		//	query = query.Where(d => d.PhieuXuats.Any(px => px.CTPhieuXuats.Any(ctpx => ctpx.MaMatHang == SelectedMatHang.MaMatHang && ctpx.ThanhTien >= ThanhTienMatHangXuatFrom && ctpx.ThanhTien <= ThanhTienMatHangXuatTo)));
		//	query = query.Where(d => d.PhieuXuats.Any(px => px.CTPhieuXuats.Any(ctpx => ctpx.MaMatHang == SelectedMatHang.MaMatHang && ctpx.MatHang != null && ctpx.MatHang.SoLuongTon >= SoLuongTonMatHangXuatFrom && ctpx.MatHang.SoLuongTon <= SoLuongTonMatHangXuatTo)));
		//	query = query.Where(d => d.PhieuXuats.Any(px => px.CTPhieuXuats.Any(ctpx => ctpx.MaMatHang == SelectedMatHang.MaMatHang && ctpx.ThanhTien >= ThanhTienMatHangXuatFrom && ctpx.ThanhTien <= ThanhTienMatHangXuatTo)));
		//}

		FilteredDaiLies = new ObservableCollection<DaiLy>(query);
    }
}