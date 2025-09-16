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
        return await _dataContext.DaiLies.MaxAsync(d => ((int?)d.MaDaiLy) ?? 0) + 1;
    }


    public async Task<DaiLy> GetDaiLyByTenAsync(string tenDaiLy)
    {
        var daily = await _dataContext.DaiLies.FirstOrDefaultAsync(d => d.TenDaiLy == tenDaiLy);
        return daily ?? throw new Exception("Bug at GetDaiLyByTenAsync");
    }

    public async Task<int> UpdateNoDaiLy(int maDaiLy, double soTienNoMoi)
    {
        var daily = await _dataContext.DaiLies.FirstOrDefaultAsync(d => d.MaDaiLy == maDaiLy);
        if(daily == null)
            throw new Exception("Bug at UpdateNoDaiLy: DaiLy not found");
        daily.NoDaiLy = soTienNoMoi;
        _dataContext.DaiLies.Update(daily);
        return await _dataContext.SaveChangesAsync();
    }
}
