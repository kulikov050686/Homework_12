using Enums;

namespace ViewModels
{
    /// <summary>
    /// Модель-Представление главного окна
    /// </summary>
    public class MainWindowViewModel : BaseClassViewModelINPC
    {
        /// <summary>
        /// Название окна
        /// </summary>
        public string Title { get; protected set; }

        /// <summary>
        /// Страница отображаемая на главном окне
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.MAINPAGE;

        #region Конструктор

        public MainWindowViewModel()
        {
            Title = "Банк ";
        }

        #endregion
    }
}
