using Microsoft.Extensions.DependencyInjection;
using ViewModels;
using Interfaces;

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
            services.AddSingleton<DepositoryAccountRepository>();

            services.AddSingleton<BankCustomersManager>();
            services.AddSingleton<DepositoryAccountsManager>();
            
            services.AddTransient<IBankCustomerDialogService, BankCustomerDialog>();
            services.AddTransient<IDepositoryAccountDialogService, DepositoryAccountDialog>();

            return services;
        }

        /// <summary>
        /// Регистрация всех моделей-представления
        /// </summary>
        /// <param name="services"></param>        
        public static IServiceCollection RegisterViewModels(this IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<MainPageViewModel>();

            services.AddTransient<MenuPageViewModel>();

            return services;
        }
    }
}
