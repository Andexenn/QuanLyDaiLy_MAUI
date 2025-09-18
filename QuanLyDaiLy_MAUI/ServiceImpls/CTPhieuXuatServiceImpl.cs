using QuanLyDaiLy_MAUI.Data;
using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Models;
using QuanLyDaiLy_MAUI.Services;

namespace QuanLyDaiLy_MAUI.ServiceImpls;

public class CTPhieuXuatServiceImpl : ICTPhieuXuatService
{
	private ICTPhieuXuatRepository _ctPhieuXuatRepository;

	public CTPhieuXuatServiceImpl(ICTPhieuXuatRepository CTPhieuXuatRepository) => _ctPhieuXuatRepository = CTPhieuXuatRepository;

	public async Task<int> AddCTPhieuXuatAsync(CTPhieuXuat ctpx) => await _ctPhieuXuatRepository.AddCTPhieuXuatAsync(ctpx);
	public async Task<int> GetNextAvailableMaCTPX() => await _ctPhieuXuatRepository.GetNextAvailableMaCTPX();
}