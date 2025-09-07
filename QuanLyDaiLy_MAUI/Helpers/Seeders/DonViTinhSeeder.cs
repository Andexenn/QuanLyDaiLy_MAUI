using Microsoft.EntityFrameworkCore;
using QuanLyDaiLy_MAUI.Models;
using System.Diagnostics;

namespace QuanLyDaiLy_MAUI.Helpers;

public static partial class DatabaseSeeder
{
	private static void SeedDonViTinh(ModelBuilder modelBuilder)
	{
#if DEBUG
		Debug.WriteLine("Seeding DonViTinh...");
#endif
        modelBuilder.Entity<DonViTinh>().HasData(
            new DonViTinh { MaDonViTinh = 1, TenDonViTinh = "Kg" },
            new DonViTinh { MaDonViTinh = 2, TenDonViTinh = "C�i" },
            new DonViTinh { MaDonViTinh = 3, TenDonViTinh = "Th�ng" },
            new DonViTinh { MaDonViTinh = 4, TenDonViTinh = "L�t" },
            new DonViTinh { MaDonViTinh = 5, TenDonViTinh = "Chai" }
        );

    }
}