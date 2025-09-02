using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.Interfaces;

public interface IThamSoRepository
{
    Task<string> GetThamSo(string key);
}
