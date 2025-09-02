using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.Services;

public interface IQuanService
{
    Task<IEnumerable<Quan>> GetAllQuanAsync();
}
