using Enums;
using System;

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
        public ApplicationPage MainPage { get; set; } = ApplicationPage.MAINPAGE;

        /// <summary>
        /// Страница с меню отображаемая на главном окне 
        /// </summary>
        public ApplicationPage MenuPage { get; set; } = ApplicationPage.MENUPAGE;
        
        #region Конструктор

        public MainWindowViewModel()
        {
            Title = "Банк ";
        }

        #endregion
    }
}
