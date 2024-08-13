using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using RMS.Data;

namespace RMS
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

            //database connection
            string connectionString = 
                "server=localhost;" +
                "user=root;" +
                "password=password;" +
                "database=demo1";
            builder.Services.AddDbContext<DatabaseContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            builder.Services.AddMauiBlazorWebView();

            //singleton for services
            builder.Services.AddSingleton<ReservationService>();
            builder.Services.AddSingleton<OrderService>();
            builder.Services.AddSingleton<MenuService>();


#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

