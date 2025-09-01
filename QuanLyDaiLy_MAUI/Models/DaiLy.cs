using SQLite;
using System.ComponentModel.DataAnnotations;
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

    // Foreign keys 
    public int MaLoaiDaiLy { get; set; }
    public virtual LoaiDaiLy? LoaiDaiLy { get; set; } = null!;
    public int MaQuan { get; set; }
    public virtual Quan? Quan { get; set; } = null!;




}