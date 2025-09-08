using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.Interfaces;

public interface IPhieuXuatRepository 
{
	Task<int> GetNextAvailableIdAsync();
	Task<int> AddPhieuXuatAsync(PhieuXuat phieuXuat);
}