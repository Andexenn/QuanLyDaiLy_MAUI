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

    public async Task<int> UpdateSoLuongTon(int maMatHang, int soLuongTonMoi)
    {
        var matHang = await _dataContext.MatHangs.FirstOrDefaultAsync(mh => mh.MaMatHang == maMatHang);
        if (matHang == null)
            throw new Exception("Bug at update so luong ton");
        matHang.SoLuongTon = soLuongTonMoi;
        _dataContext.MatHangs.Update(matHang);
        return await _dataContext.SaveChangesAsync();
    }

}