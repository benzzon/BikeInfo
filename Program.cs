using BikeApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.FluentUI.AspNetCore.Components;
using NLog.Extensions.Logging;

namespace BikeInfo
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            // Configure NLog
            var loggerFactory = LoggerFactory.Create(loggingBuilder =>
            {
                loggingBuilder.ClearProviders();
                loggingBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Information);
                loggingBuilder.AddNLog();
            });

            var logger = loggerFactory.CreateLogger("App");
            logger.LogInformation("Application starting...");

            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddFluentUIComponents();

            builder.Services.AddScoped<BikeService>();
            builder.Services.AddSingleton(loggerFactory);

            await builder.Build().RunAsync();
        }
    }
}
