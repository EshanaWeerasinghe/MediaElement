using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Mopups.Hosting;
using Mopups.Interfaces;
using Mopups.Services;

namespace MediaElement;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureMopups()
             .UseMauiCommunityToolkitMediaElement()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Logging.AddDebug();
        builder.Services.AddSingleton<IPopupNavigation>(MopupService.Instance);
        builder.Services.AddTransient<MainPage>();
        return builder.Build();

    }
}