using FreesqlGenCode.controls;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FreesqlGenCode
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainAsync().GetAwaiter().GetResult();
        }

        private static async Task MainAsync()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddSingleton<Form1>();
                })
                .Build();
            await host.StartAsync().ConfigureAwait(true);

            ApplicationConfiguration.Initialize();
            Application.Run(host.Services.GetRequiredService<Form1>());

            await host.StopAsync().ConfigureAwait(true);
        }
    }
}