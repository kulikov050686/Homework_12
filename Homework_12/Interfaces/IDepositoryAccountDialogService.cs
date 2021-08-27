using Models;
using System.Collections.Generic;

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

        /// <summary>
        /// Обновить данные депозитарного счёта
        /// </summary>
        /// <param name="depositoryAccount"> Депозитарный счёт </param>        
        DepositoryAccount UpdateDataDepositoryAccount(DepositoryAccount depositoryAccount);

        /// <summary>
        /// Объединить депозитарные счета в один счёт
        /// </summary>
        /// <param name="depositoryAccounts"> Список депозитарных счетов </param>        
        public DepositoryAccount CombiningDepositoryAccounts(IEnumerable<DepositoryAccount> depositoryAccounts);
    }
}
