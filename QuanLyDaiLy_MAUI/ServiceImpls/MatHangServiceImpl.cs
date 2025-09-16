using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Models;
using QuanLyDaiLy_MAUI.Services;

namespace QuanLyDaiLy_MAUI.ServiceImpls;

public class MatHangServiceImpl : IMatHangService
{
	private readonly IMatHangRepository _matHangRepository;
	public MatHangServiceImpl(IMatHangRepository matHangRepository) => _matHangRepository = matHangRepository;

	public async Task<IEnumerable<MatHang>> GetAllMatHangAsync()
	{
		return await _matHangRepository.GetAllMatHangAsync();
    }

	public async Task<int> UpdateSoLuongTon(int maMatHang, int soLuongTonMoi) => await _matHangRepository.UpdateSoLuongTon(maMatHang, soLuongTonMoi);
}