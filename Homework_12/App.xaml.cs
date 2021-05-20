using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services;
using System;
using System.Windows;

namespace Homework_12
{    
    public partial class App : Application
    {        
        private static IHost _host;

        /// <summary>
        /// Поле для обращения к хосту
        /// </summary>
        public static IHost Host => _host ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        /// <summary>
        /// Метод конфигурации сервисов
        /// </summary>        
        public static void ConfigureServices(HostBuilderContext host, IServiceCollection services)
        {
            services.RegisterServices().RegisterViewModels();
        }

        /// <summary>
        /// Метод запуска
        /// </summary>        
        protected override async void OnStartup(StartupEventArgs e)
        {
            var host = Host;
            base.OnStartup(e);

            await host.StartAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// Метод остановки
        /// </summary>        
        protected override async void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            var host = Host;
            await host.StopAsync().ConfigureAwait(false);
            host.Dispose();
            _host = null;
        }
    }
}
