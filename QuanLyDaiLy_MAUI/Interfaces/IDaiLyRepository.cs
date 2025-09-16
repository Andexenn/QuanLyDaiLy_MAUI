using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.Interfaces;

public interface IDaiLyRepository
{
    Task<IEnumerable<DaiLy>> GetAllDaiLyAsync();
    Task<int> AddDaiLyAsync(DaiLy daiLy);
    Task<int> GetNextAvailableIdAsync();
    Task<DaiLy> GetDaiLyByTenAsync(string tenDaiLy);
    Task<int> UpdateNoDaiLy(int maDaiLy, double soTienNoMoi);
}
