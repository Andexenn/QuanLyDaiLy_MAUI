using QuanLyDaiLy_MAUI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy_MAUI.Configs;

class DatabaseConfig
{
    private readonly DataContext _dataContext;

    public DatabaseConfig(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public DataContext DataContext => _dataContext ?? throw new Exception("DataContext null");

    public static string GetResourcePath()
    {
        string appDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ??
                              AppDomain.CurrentDomain.BaseDirectory;

        string relativePath = Path.Combine(appDirectory, @"..\..\..\..\..\QuanLyDaiLy_MAUI\Resources\Database");

        string databaseDirectory = Path.GetFullPath(relativePath);
        Directory.CreateDirectory(databaseDirectory);

        return Path.Combine(databaseDirectory, $"QuanLyDaiLy.db3");
    }

    public async Task Initialize()
    {
        await _dataContext.Database.EnsureCreatedAsync();
    }
}
