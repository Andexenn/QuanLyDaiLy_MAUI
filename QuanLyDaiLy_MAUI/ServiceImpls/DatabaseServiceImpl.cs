using QuanLyDaiLy_MAUI.Services;
using QuanLyDaiLy_MAUI.Configs;

namespace QuanLyDaiLy_MAUI.ServiceImpls;


class DatabaseServiceImpl : DatabaseService
{
    private readonly DatabaseConfig _databaseConfig;

    public DatabaseServiceImpl(DatabaseConfig databaseConfig) => _databaseConfig = databaseConfig;

    public async Task InitializeAsync()
    {
        await _databaseConfig.Initialize();
        await SeedData();
    }

    private async Task SeedData()
    {
        await Task.CompletedTask;
    }
}
