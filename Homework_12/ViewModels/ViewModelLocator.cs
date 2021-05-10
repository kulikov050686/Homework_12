using Homework_12;
using Microsoft.Extensions.DependencyInjection;

namespace ViewModels
{
    /// <summary>
    /// Класс для доступа к конкретным Моделям-Представления
    /// </summary>
    public class ViewModelLocator
    {
        public MainWindowViewModel MainWindowVM => App.Host.Services.GetRequiredService<MainWindowViewModel>();
    }
}
