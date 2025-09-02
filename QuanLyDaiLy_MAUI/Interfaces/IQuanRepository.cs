using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.Interfaces;

public interface IQuanRepository
{
    Task<IEnumerable<Quan>> GetAllQuanAsync();
}
