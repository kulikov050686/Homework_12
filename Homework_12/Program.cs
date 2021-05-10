using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

namespace Homework_12
{
    public static class Program
    {
        /// <summary>
        /// Точка входа в приложение
        /// </summary>
        [STAThread]
        public static void Main()
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }

        /// <summary>
        /// Создание хоста
        /// </summary>
        /// <param name="Args"> Аргументы командной строки </param>        
        public static IHostBuilder CreateHostBuilder(string[] Args)
        {
            var host_builder = Host.CreateDefaultBuilder(Args);

            host_builder.UseContentRoot(Environment.CurrentDirectory);
            host_builder.ConfigureAppConfiguration((host, cfg) =>
            {
                cfg.SetBasePath(Environment.CurrentDirectory);
                cfg.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            });

            host_builder.ConfigureServices(App.ConfigureServices);

            return host_builder;
        }
    }
}
