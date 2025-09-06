using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy_MAUI.Models;

public class LoaiDaiLy
{
    [Key]
    public int MaLoaiDaiLy { get; set; } // Primary Key
    public string TenLoaiDaiLy { get; set; } = string.Empty;
    public double NoToiDa { get; set; } = 0;

    // Navigation property
    public virtual List<DaiLy> DaiLies { get; set; } = [];

}
