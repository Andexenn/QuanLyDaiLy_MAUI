using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.Helpers;

public static partial class DatabaseSeeder
{
    private static void SeedQuan(ModelBuilder modelBuilder)
    {
#if DEBUG 
        Debug.WriteLine("Bug at seeding Quan data...");
#endif
        modelBuilder.Entity<Quan>().HasData(
            new Quan { MaQuan = 1, TenQuan = "Quận 1" },
            new Quan { MaQuan = 2, TenQuan = "Quận 2" },
            new Quan { MaQuan = 3, TenQuan = "Quận 3" },
            new Quan { MaQuan = 4, TenQuan = "Quận 4" },
            new Quan { MaQuan = 5, TenQuan = "Quận 5" },
            new Quan { MaQuan = 6, TenQuan = "Quận 6" },
            new Quan { MaQuan = 7, TenQuan = "Quận 7" },
            new Quan { MaQuan = 8, TenQuan = "Quận 8" },
            new Quan { MaQuan = 9, TenQuan = "Quận 9" },
            new Quan { MaQuan = 10, TenQuan = "Quận 10" },
            new Quan { MaQuan = 11, TenQuan = "Quận 11" },
            new Quan { MaQuan = 12, TenQuan = "Quận 12" },
            new Quan { MaQuan = 13, TenQuan = "Quận Bình Thạnh" },
            new Quan { MaQuan = 14, TenQuan = "Quận Tân Bình" },
            new Quan { MaQuan = 15, TenQuan = "Quận Tân Phú" },
            new Quan { MaQuan = 16, TenQuan = "Quận Phú Nhuận" },
            new Quan { MaQuan = 17, TenQuan = "Quận Gò Vấp" },
            new Quan { MaQuan = 18, TenQuan = "Quận Thủ Đức" },
            new Quan { MaQuan = 19, TenQuan = "Huyện Củ Chi" },
            new Quan { MaQuan = 20, TenQuan = "Huyện Hóc Môn" },
            // Hà Nội
            new Quan { MaQuan = 21, TenQuan = "Quận Ba Đình" },
            new Quan { MaQuan = 22, TenQuan = "Quận Hoàn Kiếm" },
            new Quan { MaQuan = 23, TenQuan = "Quận Hai Bà Trưng" },
            new Quan { MaQuan = 24, TenQuan = "Quận Đống Đa" },
            new Quan { MaQuan = 25, TenQuan = "Quận Cầu Giấy" },
            new Quan { MaQuan = 26, TenQuan = "Quận Tây Hồ" },
            new Quan { MaQuan = 27, TenQuan = "Quận Long Biên" },
            new Quan { MaQuan = 28, TenQuan = "Quận Bắc Từ Liêm" },
            new Quan { MaQuan = 29, TenQuan = "Quận Nam Từ Liêm" },
            new Quan { MaQuan = 30, TenQuan = "Quận Hà Đông" },
            // Hải Phòng
            new Quan { MaQuan = 31, TenQuan = "Quận Hồng Bàng" },
            new Quan { MaQuan = 32, TenQuan = "Quận Ngô Quyền" },
            new Quan { MaQuan = 33, TenQuan = "Quận Lê Chân" },
            new Quan { MaQuan = 34, TenQuan = "Quận Kiến An" },
            new Quan { MaQuan = 35, TenQuan = "Quận Dương Kinh" },
            // Đà Nẵng
            new Quan { MaQuan = 36, TenQuan = "Quận Hải Châu" },
            new Quan { MaQuan = 37, TenQuan = "Quận Liên Chiểu" },
            new Quan { MaQuan = 38, TenQuan = "Quận Thanh Khê" },
            new Quan { MaQuan = 39, TenQuan = "Quận Sơn Trà" },
            new Quan { MaQuan = 40, TenQuan = "Quận Ngũ Hành Sơn" },
            // Cần Thơ
            new Quan { MaQuan = 41, TenQuan = "Quận Ninh Kiều" },
            new Quan { MaQuan = 42, TenQuan = "Quận Bình Thủy" },
            new Quan { MaQuan = 43, TenQuan = "Quận Cái Răng" },
            new Quan { MaQuan = 44, TenQuan = "Quận Ô Môn" },
            new Quan { MaQuan = 45, TenQuan = "Quận Thốt Nốt" },
            // Bổ sung miền Đông & ĐBSCL
            new Quan { MaQuan = 46, TenQuan = "Quận Gò Công" },
            new Quan { MaQuan = 47, TenQuan = "Quận Tân Uyên" },
            new Quan { MaQuan = 48, TenQuan = "Quận Trảng Bàng" },
            new Quan { MaQuan = 49, TenQuan = "Huyện Châu Thành" },
            new Quan { MaQuan = 50, TenQuan = "Huyện Tân Hiệp" }
        );
    }
}