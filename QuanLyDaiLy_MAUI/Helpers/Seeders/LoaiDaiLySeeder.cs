using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using QuanLyDaiLy_MAUI.Models;

namespace QuanLyDaiLy_MAUI.Helpers;

public static partial class DatabaseSeeder
{
    private static void SeedLoaiDaiLy(ModelBuilder modelBuilder)
    {
#if DEBUG
        Debug.WriteLine("Seeding LoaiDaiLy data...");
#endif

        modelBuilder.Entity<LoaiDaiLy>().HasData(
            new LoaiDaiLy { MaLoaiDaiLy = 1, TenLoaiDaiLy = "Loại 1", NoToiDa = 60_000 },
            new LoaiDaiLy { MaLoaiDaiLy = 2, TenLoaiDaiLy = "Loại 2", NoToiDa = 80_000 },
            new LoaiDaiLy { MaLoaiDaiLy = 3, TenLoaiDaiLy = "Loại 3", NoToiDa = 100_000 },
            new LoaiDaiLy { MaLoaiDaiLy = 4, TenLoaiDaiLy = "Loại 4", NoToiDa = 120_000 },
            new LoaiDaiLy { MaLoaiDaiLy = 5, TenLoaiDaiLy = "Loại 5", NoToiDa = 135_000 },
            new LoaiDaiLy { MaLoaiDaiLy = 6, TenLoaiDaiLy = "Loại 6", NoToiDa = 150_000 },
            new LoaiDaiLy { MaLoaiDaiLy = 7, TenLoaiDaiLy = "Loại 7", NoToiDa = 165_000 },
            new LoaiDaiLy { MaLoaiDaiLy = 8, TenLoaiDaiLy = "Loại 8", NoToiDa = 180_000 },
            new LoaiDaiLy { MaLoaiDaiLy = 9, TenLoaiDaiLy = "Loại 9", NoToiDa = 190_000 },
            new LoaiDaiLy { MaLoaiDaiLy = 10, TenLoaiDaiLy = "Loại 10", NoToiDa = 200_000 }
        );

    }
}