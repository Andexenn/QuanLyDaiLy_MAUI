using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.Services;

public interface IDaiLyService
{
    Task<IEnumerable<DaiLy>> GetAllDaiLyAsync();
    Task<int> AddDaiLyAsync(DaiLy daiLy);
    Task<int> GetNextAvailableIdAsync();
    Task<DaiLy> GetDaiLyByTenAsync(string tenDaiLy);
}
