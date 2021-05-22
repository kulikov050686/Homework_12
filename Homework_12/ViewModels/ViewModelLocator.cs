using Homework_12;
using Microsoft.Extensions.DependencyInjection;

namespace ViewModels
{
    /// <summary>
    /// Класс для доступа к конкретным Моделям-Представления
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Модель-представления главного окна
        /// </summary>
        public MainWindowViewModel MainWindowVM => App.Host.Services.GetRequiredService<MainWindowViewModel>();

        /// <summary>
        /// Модель-представление управления клиетами банка
        /// </summary>
        public BankCustomersManagementViewModel BankCustomersManagementVM => App.Host.Services.GetRequiredService<BankCustomersManagementViewModel>();
    }
}
