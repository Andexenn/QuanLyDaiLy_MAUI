using Microsoft.EntityFrameworkCore;
using QuanLyDaiLy_MAUI.Data;
using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.Repositories;

public class MatHangRepository : IMatHangRepository
{
    private readonly DataContext _dataContext;
    public MatHangRepository(DataContext dataContext) => _dataContext = dataContext;

    public async Task<IEnumerable<MatHang>> GetAllMatHangAsync()
    {
        return await _dataContext.MatHangs.ToListAsync();
    }

}