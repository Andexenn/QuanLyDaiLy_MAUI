using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.Services;

public interface ILoaiDaiLyService
{
    Task<IEnumerable<LoaiDaiLy>> GetAllLoaiDaiLyAsync();
}
