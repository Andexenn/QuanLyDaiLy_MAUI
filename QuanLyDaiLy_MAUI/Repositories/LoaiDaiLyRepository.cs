using QuanLyDaiLy_MAUI.Models;
using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Data;
using Microsoft.EntityFrameworkCore;

namespace QuanLyDaiLy_MAUI.Repositories;

public class LoaiDaiLyRepository : ILoaiDaiLyRepository
{
    private readonly DataContext _dataContext;
    public LoaiDaiLyRepository(DataContext dataContext) => _dataContext = dataContext;

    public async Task<IEnumerable<LoaiDaiLy>> GetAllLoaiDaiLyAsync()
    {
        return await _dataContext.LoaiDaiLies.ToListAsync();
    }

}
