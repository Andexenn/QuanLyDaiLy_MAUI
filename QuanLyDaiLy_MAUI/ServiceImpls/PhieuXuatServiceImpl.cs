using Microsoft.EntityFrameworkCore;
using QuanLyDaiLy_MAUI.Data;
using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Services;
using QuanLyDaiLy_MAUI.Models;
namespace QuanLyDaiLy_MAUI.ServiceImpls;

public class PhieuXuatServiceImpl : IPhieuXuatService
{
	private readonly IPhieuXuatRepository _phieuXuatRepository;
	public PhieuXuatServiceImpl(IPhieuXuatRepository phieuXuatRepository) => _phieuXuatRepository = phieuXuatRepository;

	public async Task<int> GetNextAvailableIdAsync() => await _phieuXuatRepository.GetNextAvailableIdAsync();
	public async Task<int> AddPhieuXuatAsync(PhieuXuat phieuXuat) => await _phieuXuatRepository.AddPhieuXuatAsync(phieuXuat);
}