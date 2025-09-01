using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy_MAUI.Models;

public class ThamSo
{
    [Key]
    public string TenThamSo { get; set; } = string.Empty; // Primary Key
    public string GiaTri { get; set; } = string.Empty;
}
