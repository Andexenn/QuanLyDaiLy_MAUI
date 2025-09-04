using QuanLyDaiLy_MAUI.Services;
using QuanLyDaiLy_MAUI.Configs;

namespace QuanLyDaiLy_MAUI.ServiceImpls;


class DatabaseServiceImpl : DatabaseService
{
    private readonly DatabaseConfig _databaseConfig;

    public DatabaseServiceImpl(DatabaseConfig databaseConfig) => _databaseConfig = databaseConfig;

    public void InitializeAsync()
    {
        _databaseConfig.Initialize();
    }

}
