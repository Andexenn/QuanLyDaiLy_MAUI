using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.Services;

public interface IThamSoService
{
    Task<string> GetThamSoAsync(string key);
}
