using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.Services;

public interface IDonViTinhService
{
	public Task<IEnumerable<DonViTinh>> GetAllDonViTinhAsync();
}