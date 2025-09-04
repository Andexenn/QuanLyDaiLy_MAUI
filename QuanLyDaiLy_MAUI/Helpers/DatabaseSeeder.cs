using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace QuanLyDaiLy_MAUI.Helpers;

public static partial class DatabaseSeeder
{
	public static void SeedData(ModelBuilder modelBuilder)
	{
#if DEBUG
		Debug.WriteLine("Bug at seeding data...");
#endif
		
		SeedDaiLy(modelBuilder);
		SeedLoaiDaiLy(modelBuilder);
		SeedQuan(modelBuilder);
		SeedThamSo(modelBuilder);

    }
}