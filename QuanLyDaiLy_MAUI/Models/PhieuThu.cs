using System.ComponentModel.DataAnnotations;
namespace QuanLyDaiLy_MAUI.Models;

public class PhieuThu 
{
	[Key]
    public int MaPhieuThu { get; set; }
    public int MaDaiLy { get; set; }
    public DateTime NgayThuTien { get; set; } = DateTime.Now;
    public double SoTienThu { get; set; }
    public virtual DaiLy? DaiLy { get; set; } = null!;

}