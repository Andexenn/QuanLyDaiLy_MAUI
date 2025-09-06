using System.ComponentModel.DataAnnotations;

namespace QuanLyDaiLy_MAUI.Models;

public class DonViTinh 
{
	[Key]
	public int MaDonViTinh { get; set; }  // Primary Key
	public string TenDonViTinh { get; set; } = string.Empty;

    // Navigation property
	public List<MatHang> MatHangs { get; set; } = [];
}