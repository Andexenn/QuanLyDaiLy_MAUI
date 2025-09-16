using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Models;
using QuanLyDaiLy_MAUI.Services;

namespace QuanLyDaiLy_MAUI.ServiceImpls;

internal class DaiLyServiceImpl : IDaiLyService
{
    private readonly IDaiLyRepository _daiLyRepository;
    public DaiLyServiceImpl(IDaiLyRepository daiLyRepository) => _daiLyRepository = daiLyRepository;

    public async Task<IEnumerable<DaiLy>> GetAllDaiLyAsync() => await _daiLyRepository.GetAllDaiLyAsync();

    public async Task<int> AddDaiLyAsync(DaiLy daiLy) => await _daiLyRepository.AddDaiLyAsync(daiLy);
    public async Task<int> GetNextAvailableIdAsync() => await _daiLyRepository.GetNextAvailableIdAsync();
    public async Task<DaiLy> GetDaiLyByTenAsync(string tenDaiLy) => await _daiLyRepository.GetDaiLyByTenAsync(tenDaiLy);
    public async Task<int> UpdateNoDaiLy(int maDaiLy, double soTienNoMoi) => await _daiLyRepository.UpdateNoDaiLy(maDaiLy, soTienNoMoi);
}
