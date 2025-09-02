using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDaiLy_MAUI.Configs;
using Microsoft.EntityFrameworkCore;

using QuanLyDaiLy_MAUI.Data;
using QuanLyDaiLy_MAUI.ServiceImpls;
using QuanLyDaiLy_MAUI.Services;
using QuanLyDaiLy_MAUI.ViewModels;
using QuanLyDaiLy_MAUI.Views;
using QuanLyDaiLy_MAUI.Repositories;
using QuanLyDaiLy_MAUI.Interfaces;

namespace QuanLyDaiLy_MAUI.DI;

public static class AppModule
{
    public static IServiceCollection RegisterDependency(this IServiceCollection services)
    {
        services.AddSingleton<MainPage>();
        services.AddSingleton<MainPageViewModel>();
        services.AddSingleton<AddAgent>();
        services.AddSingleton<AddAgentViewModel>();

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

        // dang ky repository
        services.AddScoped<IDaiLyRepository, DaiLyRepository>();
        services.AddScoped<IQuanRepository, QuanRepository>();
        services.AddScoped<ILoaiDaiLyRepository, LoaiDaiLyRepository>();
        services.AddScoped<IThamSoRepository, ThamSoRepository>();

        // dang ky view


        return services;
    }
}
