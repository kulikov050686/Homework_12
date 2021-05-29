using Microsoft.Extensions.DependencyInjection;
using ViewModels;

namespace Services
{
    /// <summary>
    /// Класс регистрации сервисов и моделей-представления
    /// </summary>
    public static class Registrator
    {
        /// <summary>
        /// Регистрация всех сервисов
        /// </summary>
        /// <param name="services"></param>        
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<BankCustomerRepository>();
            services.AddSingleton<DepartmentRepository>();
            services.AddSingleton<BankCustomersManager>();

            return services;
        }

        /// <summary>
        /// Регистрация всех моделей-представления
        /// </summary>
        /// <param name="services"></param>        
        public static IServiceCollection RegisterViewModels(this IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();
            
            services.AddTransient<MainPageViewModel>();            

            return services;
        }
    }
}
