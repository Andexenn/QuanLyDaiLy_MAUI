using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyDaiLy_MAUI.Models;

public class CTPhieuXuat 
{
    // [Key]
    public int MaPhieuXuat { get; set; }  // Composite Primary Key part 1
    public int MaMatHang { get; set; }    // Composite Primary Key part 2

    public virtual PhieuXuat? PhieuXuat { get; set; } = null!;
    public virtual MatHang? MatHang { get; set; } = null!;
    public int SoLuongXuat { get; set; } = 0;
    public double DonGiaXuat { get; set; } = 0;
    public double ThanhTien { get; set; } = 0;

}