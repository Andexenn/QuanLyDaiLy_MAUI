using QuanLyDaiLy_MAUI.Models;
using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Data;
using Microsoft.EntityFrameworkCore;

namespace QuanLyDaiLy_MAUI.Repositories;

public class ThamSoRepository : IThamSoRepository
{
    private readonly DataContext _dataContext;
    public ThamSoRepository(DataContext dataContext) => _dataContext = dataContext;

    public Task<string> GetThamSo(string key) => (Task<string>)_dataContext.ThamSos.Where(ts => ts.TenThamSo == key).Select(ts => ts.GiaTri).FirstOrDefaultAsync()!;
}
