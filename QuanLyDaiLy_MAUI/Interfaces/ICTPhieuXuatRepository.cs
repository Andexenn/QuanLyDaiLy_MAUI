using QuanLyDaiLy_MAUI.Models;
namespace QuanLyDaiLy_MAUI.Interfaces;

public interface ICTPhieuXuatRepository
{
	Task<int> AddCTPhieuXuatAsync(CTPhieuXuat ctpx);
	Task<int> GetNextAvailableMaCTPX();
}