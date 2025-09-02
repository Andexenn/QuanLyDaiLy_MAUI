using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Services;
using QuanLyDaiLy_MAUI.Models;


namespace QuanLyDaiLy_MAUI.ServiceImpls;

public class QuanServiceImpl : IQuanService
{
    private readonly IQuanRepository _quanRepository;
    public QuanServiceImpl(IQuanRepository quanRepository) => _quanRepository = quanRepository;
    public async Task<IEnumerable<Quan>> GetAllQuanAsync() => await _quanRepository.GetAllQuanAsync();
}
