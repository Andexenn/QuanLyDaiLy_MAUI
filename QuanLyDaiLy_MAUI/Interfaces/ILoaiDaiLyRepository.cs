using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.Interfaces;

public interface ILoaiDaiLyRepository
{
    Task<IEnumerable<LoaiDaiLy>> GetAllLoaiDaiLyAsync();
}
