using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace QuanLyDaiLy_MAUI.Helpers;

public static partial class DatabaseSeeder
{
	public static void SeedData(ModelBuilder modelBuilder)
	{
#if DEBUG
		Debug.WriteLine("Seeding data...");
#endif
		
		SeedDaiLy(modelBuilder);
		SeedLoaiDaiLy(modelBuilder);
		SeedQuan(modelBuilder);
		SeedThamSo(modelBuilder);
		SeedDonViTinh(modelBuilder);
		SeedMatHang(modelBuilder);
        SeedPhieuXuat(modelBuilder);
    }
}