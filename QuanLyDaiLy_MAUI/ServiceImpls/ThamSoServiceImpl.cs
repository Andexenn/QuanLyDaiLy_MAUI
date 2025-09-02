using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Models;
using QuanLyDaiLy_MAUI.Services;
namespace QuanLyDaiLy_MAUI.ServiceImpls;

public class ThamSoServiceImpl : IThamSoService
{
    private readonly IThamSoRepository _thamSoService;
    public ThamSoServiceImpl(IThamSoRepository thamSoService) => _thamSoService = thamSoService;
    public async Task<string> GetThamSoAsync(string key) => await _thamSoService.GetThamSo(key);
}
