using Microsoft.Extensions.Logging;
using QuanLyDaiLy_MAUI.DI;
using QuanLyDaiLy_MAUI.Services;
using Syncfusion.Maui.Toolkit.Hosting;

namespace QuanLyDaiLy_MAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
#pragma warning disable MCT001 // `.UseMauiCommunityToolkit()` Not Found on MauiAppBuilder
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("MONTSERRAT-BOLD.TTF", "MontserratBold");
                    fonts.AddFont("MONTSERRAT-REGULAR.TTF", "MontserratRegular");
                    fonts.AddFont("MONTSERRAT-SEMIBOLD.TTF", "MontserratSemiBold");
                    fonts.AddFont("Font-Awesome-7-Free-Solid-900.otf", "FontAwesomeSolid");
                });
#pragma warning restore MCT001 // `.UseMauiCommunityToolkit()` Not Found on MauiAppBuilder

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.RegisterDependency();

            var appBuilder = builder.Build();

            appBuilder.Services.GetRequiredService<DatabaseService>().InitializeAsync();


            return appBuilder;
        }
    }
}
