using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Services;
using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.ServiceImpls;

public class DonViTinhServiceImpl : IDonViTinhService
{
	private readonly IDonViTinhRepository _donViTinhRepository;
	public DonViTinhServiceImpl(IDonViTinhRepository donViTinhRepository) => _donViTinhRepository = donViTinhRepository;
	public async Task<IEnumerable<DonViTinh>> GetAllDonViTinhAsync() => await _donViTinhRepository.GetAllDonViTinhAsync();
}