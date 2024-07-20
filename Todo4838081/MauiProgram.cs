using Microsoft.Extensions.Logging;
using Todo4838081.Data;
using Todo4838081.Views;

namespace Todo4838081
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<TodoListPage>();
            builder.Services.AddTransient<TodoListPage>();

            builder.Services.AddSingleton<TodoItemDatabase>();


            return builder.Build();
        }
    }
}
