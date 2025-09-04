using SQLite;
using QuanLyDaiLy_MAUI.Models;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using QuanLyDaiLy_MAUI.Helpers;
namespace QuanLyDaiLy_MAUI.Data;

public class DataContext : DbContext
{
	public DataContext(DbContextOptions<DataContext> options) : base(options) { }

	public DbSet<DaiLy> DaiLies { get; set; } = null!;
	public DbSet<LoaiDaiLy> LoaiDaiLies { get; set; } = null!;
    public DbSet<Quan> Quans { get; set; } = null!;
	public DbSet<ThamSo> ThamSos { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<LoaiDaiLy>()
            .HasMany(ldl => ldl.DaiLies)
            .WithOne(dl => dl.LoaiDaiLy)
            .HasForeignKey(dl => dl.MaLoaiDaiLy)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Quan>()
            .HasMany(q => q.DaiLies)
            .WithOne(dl => dl.Quan)
            .HasForeignKey(dl => dl.MaQuan)
            .OnDelete(DeleteBehavior.Cascade);

        DatabaseSeeder.SeedData(modelBuilder);
    }

}