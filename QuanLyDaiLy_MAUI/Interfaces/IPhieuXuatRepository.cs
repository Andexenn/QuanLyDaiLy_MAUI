namespace QuanLyDaiLy_MAUI.Interfaces;

public interface IPhieuXuatRepository 
{
	Task<int> GetNextAvailableIdAsync();
}