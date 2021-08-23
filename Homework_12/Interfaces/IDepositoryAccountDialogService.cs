using Models;

namespace Interfaces
{
    /// <summary>
    /// Интерфейс сервиса диалоговых окон по работе с депозитарным счётом
    /// </summary>
    public interface IDepositoryAccountDialogService
    {
        /// <summary>
        /// Создание нового депозитарного счёта
        /// </summary>             
        DepositoryAccount CreateNewDepositoryAccount();
    }
}
