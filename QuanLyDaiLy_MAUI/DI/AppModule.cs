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

        services.AddScoped<DatabaseService, DatabaseServiceImpl>();

        return services;
    }
}
