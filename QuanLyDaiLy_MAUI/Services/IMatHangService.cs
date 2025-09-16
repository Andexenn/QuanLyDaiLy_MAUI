using QuanLyDaiLy_MAUI.Models;
namespace QuanLyDaiLy_MAUI.Services;

public interface IMatHangService 
{
	Task<IEnumerable<MatHang>> GetAllMatHangAsync();
	Task<int> UpdateSoLuongTon(int maMatHang, int soLuongTonMoi);
}