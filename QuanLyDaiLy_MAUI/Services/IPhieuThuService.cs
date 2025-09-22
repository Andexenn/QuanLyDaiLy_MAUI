using QuanLyDaiLy_MAUI.Models;  
namespace QuanLyDaiLy_MAUI.Services;

public interface IPhieuThuService
{
    public Task<int> GetNextAvailableIdAsync();
    public Task<int> AddPhieuThuAsync(PhieuThu phieuThu);
    public Task<IEnumerable<PhieuThu>> GetAllPhieuThuAsync();
}