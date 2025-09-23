using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuanLyDaiLy_MAUI.Services;
using System.Collections.ObjectModel;
using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.ViewModels.DaiLyViewModels;

public partial class DaiLyHopLe : ObservableObject
{
	[ObservableProperty]
	int soThuTu;
	[ObservableProperty]
	string tenDaiLy = string.Empty;
	[ObservableProperty]
	int soLuongPhieuXuat = 0;
	[ObservableProperty]
	double tongGiaTriGiaoDichTrongThang = 0;
	[ObservableProperty]
	double tiLe = 0;
}

public partial class LapBaoCaoDoanhSoTheoThangPageViewModel : BaseViewModel
{
	private readonly IDaiLyService _daiLyService;
	private readonly IPhieuXuatService _phieuXuatService;
	public LapBaoCaoDoanhSoTheoThangPageViewModel(IDaiLyService daiLyService, IPhieuXuatService phieuXuatService)
	{
		_daiLyService = daiLyService;
		_phieuXuatService = phieuXuatService;

		_ = LoadDataAsync();
    }

	[ObservableProperty]
	private int thangBaoCao = DateTime.Now.Month;
	[ObservableProperty]
	private int namBaoCao = DateTime.Now.Year;
	[ObservableProperty]
	ObservableCollection<DaiLyHopLe> danhSachDaiLyHopLe = [];
	[ObservableProperty]
	private double tongGiaTriGiaoDichCuaTatCaDaiLy = 0;

    List<DaiLy> DaiLies = [];
	List<PhieuXuat> PhieuXuats = [];


    [RelayCommand]
	async Task CloseWindow()
	{
		await Shell.Current.GoToAsync("..");
    }

	[RelayCommand]
	void LapBaoCaoDoanhSo()
	{
		DanhSachDaiLyHopLe.Clear();
		TongGiaTriGiaoDichCuaTatCaDaiLy = 0;
		foreach(var dl in DaiLies)
		{
			var phieuxuats = PhieuXuats.Where(px => px.MaDaiLy == dl.MaDaiLy && px.NgayLapPhieu.Month == ThangBaoCao && px.NgayLapPhieu.Year == NamBaoCao).ToList();
			if (phieuxuats.Count > 0)
			{
				var daiLyHopLe = new DaiLyHopLe
				{
					SoThuTu = DanhSachDaiLyHopLe.Count + 1,
					TenDaiLy = dl.TenDaiLy,
					SoLuongPhieuXuat = phieuxuats.Count,
					TongGiaTriGiaoDichTrongThang = phieuxuats.Sum(px => px.TongTriGia),
				};
				TongGiaTriGiaoDichCuaTatCaDaiLy += daiLyHopLe.TongGiaTriGiaoDichTrongThang;
                //daiLyHopLe.TiLe = Math.Round(TongGiaTriGiaoDichCuaTatCaDaiLy/daiLyHopLe.TongGiaTriGiaoDichTrongThang,2);
				DanhSachDaiLyHopLe.Add(daiLyHopLe);
            }
        }

		foreach(var dl in DanhSachDaiLyHopLe)
		{
			dl.TiLe = Math.Round(dl.TongGiaTriGiaoDichTrongThang / TongGiaTriGiaoDichCuaTatCaDaiLy, 2);
        }
    }

	async Task LoadDataAsync()
	{
		IsLoading = true;
		await Task.Yield();
		try
		{
			var dailies = await _daiLyService.GetAllDaiLyAsync();
			DaiLies = new List<DaiLy>(dailies);
			var phieuxuats = await _phieuXuatService.GetAllPhieuXuatAsync();
			PhieuXuats = new List<PhieuXuat>(phieuxuats);
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