using QuanLyDaiLy_MAUI.Models;
using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Data;
using Microsoft.EntityFrameworkCore;

namespace QuanLyDaiLy_MAUI.Repositories;

public class QuanRepository : IQuanRepository
{
    private readonly DataContext _dataContext;
    public QuanRepository(DataContext dataContext) => _dataContext = dataContext;
    public async Task<IEnumerable<Quan>> GetAllQuanAsync()
    {
        return await _dataContext.Quans.ToListAsync();
    }
}
