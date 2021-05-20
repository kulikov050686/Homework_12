using Microsoft.Extensions.DependencyInjection;
using ViewModels;

namespace Services
{
    /// <summary>
    /// 
    /// </summary>
    public static class Registrator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<BankCustomerRepository>();
            services.AddSingleton<DepartmentRepository>();

            return services;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterViewModels(this IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();

            services.AddTransient<BankCustomersManagementViewModel>();

            return services;
        }
    }
}
