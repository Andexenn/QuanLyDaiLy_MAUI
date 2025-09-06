using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy_MAUI.Models;

public class Quan
{
    [Key]
    public int MaQuan { get; set; } // Primary Key
    public string TenQuan { get; set; } = string.Empty;

    // Navigation property

    public virtual List<DaiLy> DaiLies { get; set; } = [];
}
