using System.ComponentModel.DataAnnotations;

namespace QuanLyDaiLy_MAUI.Models;

public class MatHang 
{
	[Key]
	public int MaMatHang { get; set; }  

	public string TenMatHang { get; set; } = string.Empty;
	public int SoLuongTon { get; set; } = 0;

    // Navigation property
    public List<CTPhieuXuat> CTPhieuXuats { get; set; } = [];
    public DonViTinh DonViTinh { get; set; } = null!;

    // Foreign key
    public int MaDonViTinh { get; set; }
}