namespace Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для диалога с пользователем
    /// </summary>
    public interface IUserDialogService
    {
        /// <summary>
        /// Редактировать некоторый объект
        /// </summary>
        /// <param name="item"> Редактируемый объект </param>        
        bool Edit(object item);

        /// <summary>
        /// Отображение информационных сообщений
        /// </summary>
        /// <param name="information"> Информационное сообщение </param>
        /// <param name="caption"> Заголовок </param>
        void ShowInformation(string information, string caption);

        /// <summary>
        /// Отображение предупреждающих сообщений
        /// </summary>
        /// <param name="message"> Предупреждающее сообщение </param>
        /// <param name="caption"> Заголовок </param>
        void ShowWarning(string message, string caption);

        /// <summary>
        /// Отображение сообщений об ошибках
        /// </summary>
        /// <param name="message"> Сообщение об ошибке </param>
        /// <param name="caption"> Заголовок </param>
        void ShowError(string message, string caption);

        /// <summary>
        /// Согласие пользователя
        /// </summary>
        /// <param name="message"></param>
        /// <param name="caption"> Заголовок </param>
        /// <param name="exclamation"></param>        
        bool Confirm(string message, string caption, bool exclamation = false);
    }
}
