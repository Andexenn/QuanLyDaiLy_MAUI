using QuanLyDaiLy_MAUI.Configs;
using Microsoft.EntityFrameworkCore;

using QuanLyDaiLy_MAUI.Data;
using QuanLyDaiLy_MAUI.ServiceImpls;
using QuanLyDaiLy_MAUI.Services;
using QuanLyDaiLy_MAUI.ViewModels;
using QuanLyDaiLy_MAUI.Views;
using QuanLyDaiLy_MAUI.Repositories;
using QuanLyDaiLy_MAUI.Interfaces;
using QuanLyDaiLy_MAUI.Views.DaiLyViews;

namespace QuanLyDaiLy_MAUI.DI;

public static class AppModule
{
    public static IServiceCollection RegisterDependency(this IServiceCollection services)
    {
        

        services.AddSingleton<DatabaseConfig>();

        services.AddDbContext<DataContext>((serviceProviders, options) =>
        {
            var databasePath = DatabaseConfig.GetResourcePath();
            options.UseSqlite($"Data Source={databasePath}");
        });

        // dang ky service
        services.AddScoped<DatabaseService, DatabaseServiceImpl>();
        services.AddScoped<IDaiLyService, DaiLyServiceImpl>();
        services.AddScoped<IQuanService, QuanServiceImpl>();
        services.AddScoped<ILoaiDaiLyService, LoaiDaiLyServiceImpl>();
        services.AddScoped<IThamSoService, ThamSoServiceImpl>();
        services.AddScoped<IPhieuXuatService, PhieuXuatServiceImpl>();
        services.AddScoped<IMatHangService, MatHangServiceImpl>();
        services.AddScoped<ICTPhieuXuatService, CTPhieuXuatServiceImpl>();
        services.AddScoped<IDonViTinhService, DonViTinhServiceImpl>();

        // dang ky repository
        services.AddScoped<IDaiLyRepository, DaiLyRepository>();
        services.AddScoped<IQuanRepository, QuanRepository>();
        services.AddScoped<ILoaiDaiLyRepository, LoaiDaiLyRepository>();
        services.AddScoped<IThamSoRepository, ThamSoRepository>();
        services.AddScoped<IPhieuXuatRepository, PhieuXuatRepository>();
        services.AddScoped<IMatHangRepository, MatHangRepository>();
        services.AddScoped<ICTPhieuXuatRepository, CTPhieuXuatRepository>();
        services.AddScoped<IDonViTinhRepository, DonViTinhRepository>();

        // dang ky view
        services.AddTransient<DanhSachDaiLyPage>();
        services.AddTransient<ThemDaiLyModal>();
        services.AddTransient<LapPhieuXuatModal>();
        services.AddTransient<TraCuuDaiLyPage>();

        //dang ky viewmodel
        services.AddTransient<ViewModels.DaiLyViewModels.DanhSachDaiLyPageViewModel>();
        services.AddTransient<ViewModels.DaiLyViewModels.ThemDaiLyModalViewModel>();
        services.AddTransient<ViewModels.PhieuXuatViewModels.LapPhieuXuatModalViewModel>();
        services.AddTransient<ViewModels.DaiLyViewModels.TraCuuDaiLyPageViewModel>();

        return services;
    }
}
