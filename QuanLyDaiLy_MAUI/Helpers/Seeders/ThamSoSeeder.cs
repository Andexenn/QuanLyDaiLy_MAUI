using Microsoft.EntityFrameworkCore;
using QuanLyDaiLy_MAUI.Models;
using System.Diagnostics;
namespace QuanLyDaiLy_MAUI.Helpers;

public static partial class DatabaseSeeder
{
	private static void SeedThamSo(ModelBuilder modelBuilder)
	{
#if DEBUG
		Debug.WriteLine("Bug at seeding ThamSo data...");
#endif
		modelBuilder.Entity<ThamSo>().HasData(
			new ThamSo { TenThamSo = "SoLuongDaiLyToiDa", GiaTri = "10" }
		);
	}
}