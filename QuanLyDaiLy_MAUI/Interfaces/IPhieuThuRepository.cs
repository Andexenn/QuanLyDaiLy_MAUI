using QuanLyDaiLy_MAUI.Models;
namespace QuanLyDaiLy_MAUI.Interfaces;

public interface IPhieuThuRepository 
{
	public Task<int> GetNextAvailableIdAsync();
	public Task<int> AddPhieuThuAsync(PhieuThu phieuThu);
	public Task<IEnumerable<PhieuThu>> GetAllPhieuThuAsync();
}