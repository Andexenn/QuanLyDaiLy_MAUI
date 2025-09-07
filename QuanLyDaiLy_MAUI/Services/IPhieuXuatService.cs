namespace QuanLyDaiLy_MAUI.Services;

public interface IPhieuXuatService 
{ 
	Task<int> GetNextAvailableIdAsync();
}