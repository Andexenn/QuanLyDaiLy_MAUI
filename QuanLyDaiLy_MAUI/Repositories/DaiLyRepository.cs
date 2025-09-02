using QuanLyDaiLy_MAUI.Models;
using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Data;
using Microsoft.EntityFrameworkCore;

namespace QuanLyDaiLy_MAUI.Repositories;

public class DaiLyRepository : IDaiLyRepository
{
    private readonly DataContext _dataContext;
    public DaiLyRepository(DataContext dataContext) => _dataContext = dataContext;

    public async Task<IEnumerable<DaiLy>> GetAllDaiLyAsync()
    {
        return await _dataContext.DaiLies.Include(d => d.Quan).Include(d => d.LoaiDaiLy).ToListAsync();
    }

    public async Task<int> AddDaiLyAsync(DaiLy daiLy)
    {
        await _dataContext.DaiLies.AddAsync(daiLy);
        return await _dataContext.SaveChangesAsync();
    }

    public async Task<int> GetNextAvailableIdAsync()
    {
        return await _dataContext.DaiLies.MaxAsync(d => (int?)d.MaDaiLy) ?? 0 + 1;
    }



}
