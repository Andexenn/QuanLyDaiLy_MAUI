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
		
		SeedLoaiDaiLy(modelBuilder);
		SeedQuan(modelBuilder);
		SeedThamSo(modelBuilder);
		SeedDaiLy(modelBuilder);
		SeedDonViTinh(modelBuilder);
        SeedPhieuXuat(modelBuilder);
        SeedPhieuThu(modelBuilder);
        SeedMatHang(modelBuilder);
		SeedCTPhieuXuat(modelBuilder);
		
    }
}