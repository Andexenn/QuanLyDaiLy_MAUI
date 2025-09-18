using QuanLyDaiLy_MAUI.Models;
namespace QuanLyDaiLy_MAUI.Services;

public interface ICTPhieuXuatService 
{
	public Task<int> AddCTPhieuXuatAsync(CTPhieuXuat ctpx);
    public Task<int> GetNextAvailableMaCTPX();
}