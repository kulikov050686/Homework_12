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
        /// 
        /// </summary>
        /// <param name="depositoryAccount"></param>        
        DepositoryAccount UpdateDataDepositoryAccount(DepositoryAccount depositoryAccount);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="depositoryAccounts"></param>        
        public DepositoryAccount CombiningDepositoryAccounts(IEnumerable<DepositoryAccount> depositoryAccounts);
    }
}
