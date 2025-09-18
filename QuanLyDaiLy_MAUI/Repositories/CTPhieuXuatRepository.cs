using Microsoft.EntityFrameworkCore;
using QuanLyDaiLy_MAUI.Data;
using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Models;
namespace QuanLyDaiLy_MAUI.Repositories;

public class CTPhieuXuatRepository : ICTPhieuXuatRepository
{
	private readonly DataContext _dataContext;
	public CTPhieuXuatRepository(DataContext dataContext) => _dataContext = dataContext;

	public async Task<int> AddCTPhieuXuatAsync(CTPhieuXuat ctpx)
	{
		await _dataContext.AddAsync(ctpx);
		return await _dataContext.SaveChangesAsync();
	}

	public async Task<int> GetNextAvailableMaCTPX()
	{
		return await _dataContext.CTPhieuXuats.MaxAsync(ctpx => (int?)ctpx.MaCTPhieuXuat ?? 0) + 1;
    }

}