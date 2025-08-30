using Microsoft.Extensions.Logging;

namespace QuanLyDaiLy_MAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("MONTSERRAT-BOLD.TTF", "MontserratBold");
                    fonts.AddFont("MONTSERRAT-REGULAR.TTF", "MontserratRegular");
                    fonts.AddFont("MONTSERRAT-SEMIBOLD.TTF", "MontserratSemiBold");
                    fonts.AddFont("Font-Awesome-7-Free-Solid-900.otf", "FontAwesomeSolid");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<ViewModels.MainPageViewModel>();
            return builder.Build();
        }
    }
}
