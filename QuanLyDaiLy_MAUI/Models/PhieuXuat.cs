using System.ComponentModel.DataAnnotations;

namespace QuanLyDaiLy_MAUI.Models;

public class PhieuXuat
{
	[Key]
	public int MaPhieuXuat { get; set; }  
	
	public DateTime NgayLap { get; set; } = DateTime.Now;
	public double TongGiaTri { get; set; } = 0;

    // navigation property
    public List<CTPhieuXuat> CTPhieuXuats { get; set; } = [];
	public virtual DaiLy? DaiLy { get; set; } = null!;

    // Foreign key
    public int MaDaiLy { get; set;} = 0;

}