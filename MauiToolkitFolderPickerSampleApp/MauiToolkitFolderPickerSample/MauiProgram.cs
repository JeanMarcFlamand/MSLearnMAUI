using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Storage;
using Microsoft.Extensions.Logging;

namespace MauiToolkitFolderPickerSample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            // Initialise the toolkit
            builder.UseMauiApp<App>()
                   .UseMauiCommunityToolkitCore();


            builder.Services.AddSingleton<IFolderPicker>(FolderPicker.Default);
            builder.Services.AddTransient<MainPage>();

            builder.ConfigureFonts(fonts =>
             {
                 fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                 fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
             });
            

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
