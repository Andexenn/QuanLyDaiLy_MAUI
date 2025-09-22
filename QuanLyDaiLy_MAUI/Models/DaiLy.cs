using SQLite;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QuanLyDaiLy_MAUI.Models;


public class DaiLy 
{
	[Key]
	public int MaDaiLy { get; set; } // Primary Key
    public string TenDaiLy { get; set; } = string.Empty;
    public string DiaChi { get; set; } = string.Empty;  
    public string SoDienThoai { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime NgayTiepNhan { get; set; } = DateTime.Now;
    public double NoDaiLy { get; set; } = 0;

    // Navigation properties
    public virtual List<PhieuXuat> PhieuXuats { get; set; } = [];
    public virtual List<PhieuThu> PhieuThus { get; set; } = [];
    public virtual LoaiDaiLy? LoaiDaiLy { get; set; } = null!;
    public virtual Quan? Quan { get; set; } = null!;


    // Foreign keys 
    public int MaLoaiDaiLy { get; set; }
    public int MaQuan { get; set; }


}