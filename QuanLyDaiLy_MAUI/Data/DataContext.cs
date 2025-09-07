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
    public DbSet<PhieuXuat> PhieuXuats { get; set; } = null!;
    public DbSet<CTPhieuXuat> CTPhieuXuats { get; set; } = null!;
    public DbSet<MatHang> MatHangs { get; set; } = null!;
    public DbSet<DonViTinh> DonViTinhs { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<CTPhieuXuat>()
            .HasKey(ctpx => new { ctpx.MaPhieuXuat, ctpx.MaMatHang });

        // LoaiDaiLy - DaiLy (1 - N)
        modelBuilder.Entity<LoaiDaiLy>()
            .HasMany(ldl => ldl.DaiLies)
            .WithOne(dl => dl.LoaiDaiLy)
            .HasForeignKey(dl => dl.MaLoaiDaiLy)
            .OnDelete(DeleteBehavior.Cascade);

        // Quan - DaiLy (1 - N)
        modelBuilder.Entity<Quan>()
            .HasMany(q => q.DaiLies)
            .WithOne(dl => dl.Quan)
            .HasForeignKey(dl => dl.MaQuan)
            .OnDelete(DeleteBehavior.Cascade);

        // DaiLy - PhieuXuat (1 - N)
        modelBuilder.Entity<DaiLy>()
           .HasMany(dl => dl.PhieuXuats)
           .WithOne(px => px.DaiLy)
           .HasForeignKey(px => px.MaDaiLy)
           .OnDelete(DeleteBehavior.Cascade);

        // PhieuXuat - CTPhieuXuat (1 - N)
        modelBuilder.Entity<PhieuXuat>()
            .HasMany(px => px.CTPhieuXuats)
            .WithOne(ctpx => ctpx.PhieuXuat)
            .HasForeignKey(ctpx => ctpx.MaPhieuXuat)
            .OnDelete(DeleteBehavior.Cascade);

        // MatHang - CTPhieuXuat (1 - N)
        modelBuilder.Entity<MatHang>()
            .HasMany(mh => mh.CTPhieuXuats)
            .WithOne(ctpx => ctpx.MatHang)
            .HasForeignKey(CTPhieuXuat => CTPhieuXuat.MaMatHang)
            .OnDelete(DeleteBehavior.Cascade);

        // DonViTinh - MatHang (1 - N)
        modelBuilder.Entity<DonViTinh>()
            .HasMany(dvt => dvt.MatHangs)
            .WithOne(mh => mh.DonViTinh)
            .HasForeignKey(mh => mh.MaDonViTinh)
            .OnDelete(DeleteBehavior.Cascade);

        DatabaseSeeder.SeedData(modelBuilder);
    }

}