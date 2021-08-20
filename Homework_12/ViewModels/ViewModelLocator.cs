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
        /// Модель-представление главной страницы
        /// </summary>
        public MainPageViewModel MainPageVM => App.Host.Services.GetRequiredService<MainPageViewModel>();

        /// <summary>
        /// Молель-представление страницы с меню
        /// </summary>
        public MenuPageViewModel MenuPageVM => App.Host.Services.GetRequiredService<MenuPageViewModel>();
    }
}
