using SQLite;
using System.ComponentModel.DataAnnotations;
namespace QuanLyDaiLy_MAUI.Models;

[Table("DaiLy")]
public class DaiLy 
{
	[PrimaryKey, AutoIncrement]
    public int MaDaiLy { get; set; } // Primary Key

    public int MaLoaiDaiLy { get; set; } // Foreign Key
    public int MaQuan { get; set; } // Foreign Key

	[Required(ErrorMessage = "Tên đại lý không được để trống")]
	[System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Tên đại lý không được vượt quá 100 ký tự")]
    public string TenDaiLy { get; set; } 
	[Required(ErrorMessage = "Địa chỉ không được để trống")]
    public string DiaChi { get; set; }

	[Indexed(Unique = true)]
    [Required(ErrorMessage = "Số điện thoại không được để trống")]
    public string SoDienThoai { get; set; }

	[Indexed(Unique = true)]
	[Required(ErrorMessage = "Email không được để trống")]
    public string Email { get; set; }


	public DateTime NgayTiepNhan { get; set; } = DateTime.Now;
	public long NoDaiLy { get; set; } = 0;

    public DaiLy()
	{
		
	}
}