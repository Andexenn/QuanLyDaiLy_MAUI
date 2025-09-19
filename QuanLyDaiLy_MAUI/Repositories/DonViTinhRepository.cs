using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Data;
using Microsoft.EntityFrameworkCore;
using QuanLyDaiLy_MAUI.Models;
namespace QuanLyDaiLy_MAUI.Repositories;

public class DonViTinhRepository : IDonViTinhRepository
{
	private readonly DataContext _dataContext;
    public DonViTinhRepository(DataContext dataContext) => _dataContext = dataContext;

    public async Task<IEnumerable<DonViTinh>> GetAllDonViTinhAsync() => await _dataContext.DonViTinhs.ToListAsync();
}