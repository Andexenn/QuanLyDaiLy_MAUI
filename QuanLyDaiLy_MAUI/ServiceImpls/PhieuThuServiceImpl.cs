using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Repositories;
using QuanLyDaiLy_MAUI.Services;

namespace QuanLyDaiLy_MAUI.ServiceImpls;

public class PhieuThuServiceImpl : IPhieuThuService
{
	private IPhieuThuRepository _phieuThuRepository;
	public PhieuThuServiceImpl(IPhieuThuRepository phieuThuRepository)
	{
		_phieuThuRepository = phieuThuRepository;
    }

	public async Task<int> GetNextAvailableIdAsync() => await _phieuThuRepository.GetNextAvailableIdAsync();
	public async Task<int> AddPhieuThuAsync(Models.PhieuThu phieuThu) => await _phieuThuRepository.AddPhieuThuAsync(phieuThu);
	public async Task<IEnumerable<Models.PhieuThu>> GetAllPhieuThuAsync() => await _phieuThuRepository.GetAllPhieuThuAsync();
}