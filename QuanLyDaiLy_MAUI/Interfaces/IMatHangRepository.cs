using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.Interfaces;

public interface IMatHangRepository
{
	Task<IEnumerable<MatHang>> GetAllMatHangAsync();
	Task<int> UpdateSoLuongTon(int maMatHang, int soLuongTonMoi);
}