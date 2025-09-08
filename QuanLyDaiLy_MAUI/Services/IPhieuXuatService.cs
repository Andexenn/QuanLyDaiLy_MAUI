using QuanLyDaiLy_MAUI.Models;
namespace QuanLyDaiLy_MAUI.Services;

public interface IPhieuXuatService 
{ 
	Task<int> GetNextAvailableIdAsync();
	Task<int> AddPhieuXuatAsync(PhieuXuat phieuXuat);
}