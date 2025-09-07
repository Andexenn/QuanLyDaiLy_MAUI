using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Data;
using Microsoft.EntityFrameworkCore;
namespace QuanLyDaiLy_MAUI.Repositories;

public class PhieuXuatRepository : IPhieuXuatRepository
{
	private readonly DataContext _dataContext;
	public PhieuXuatRepository(DataContext dataContext) => _dataContext = dataContext;

	public async Task<int> GetNextAvailableIdAsync()
	{
		//return 1;
		return await _dataContext.PhieuXuats.MaxAsync(px => ((int?)px.MaPhieuXuat) ?? 0) + 1;
    }
}