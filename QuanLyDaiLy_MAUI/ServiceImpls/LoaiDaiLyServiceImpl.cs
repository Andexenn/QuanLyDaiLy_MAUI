using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Models;
using QuanLyDaiLy_MAUI.Services;

namespace QuanLyDaiLy_MAUI.ServiceImpls;

public class LoaiDaiLyServiceImpl : ILoaiDaiLyService
{
    private readonly ILoaiDaiLyRepository _loaiDaiLyRepository;
    public LoaiDaiLyServiceImpl(ILoaiDaiLyRepository loaiDaiLyRepository) => _loaiDaiLyRepository = loaiDaiLyRepository;
    public async Task<IEnumerable<LoaiDaiLy>> GetAllLoaiDaiLyAsync() => await _loaiDaiLyRepository.GetAllLoaiDaiLyAsync();

}
