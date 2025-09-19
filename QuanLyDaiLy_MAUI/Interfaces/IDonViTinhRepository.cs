using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.Interfaces;

public interface IDonViTinhRepository
{
	Task<IEnumerable<DonViTinh>> GetAllDonViTinhAsync();
}