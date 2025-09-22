using Microsoft.EntityFrameworkCore;
using QuanLyDaiLy_MAUI.Data;
using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.Repositories;

public class PhieuThuRepository : IPhieuThuRepository
{
	private readonly DataContext _dataContext;
	public PhieuThuRepository(DataContext dataContext) => _dataContext = dataContext;

	public async Task<int> GetNextAvailableIdAsync() =>  await _dataContext.PhieuThus.MaxAsync(pt => (int?)pt.MaPhieuThu ?? 0) + 1;
	public async Task<int> AddPhieuThuAsync(PhieuThu phieuThu)
	{
		await _dataContext.PhieuThus.AddAsync(phieuThu);
		return await _dataContext.SaveChangesAsync();
    }

	public async Task<IEnumerable<PhieuThu>> GetAllPhieuThuAsync()
	{
		return await _dataContext.PhieuThus.ToListAsync();
    }
}