using Microsoft.EntityFrameworkCore;
using QuanLyDaiLy_MAUI.Models;
using System.Diagnostics;
namespace QuanLyDaiLy_MAUI.Helpers;

public static partial class DatabaseSeeder
{
	private static void SeedThamSo(ModelBuilder modelBuilder)
	{
#if DEBUG
		Debug.WriteLine("Seeding ThamSo data...");
#endif
		modelBuilder.Entity<ThamSo>().HasData(
			new ThamSo { TenThamSo = "SoLuongDaiLyToiDa", GiaTri = "10" },
			new ThamSo { TenThamSo = "QuyDinhTienThuTienNo", GiaTri = "1000000" }
		);
	}
}