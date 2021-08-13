using Enums;
using Models;

namespace Interfaces
{
    /// <summary>
    /// Интерфейс сервиса диалоговых окон по работе с клиентом банка
    /// </summary>
    public interface IBankCustomerDialogService
    {
        /// <summary>
        /// Создание нового клиента банка
        /// </summary>
        /// <param name="clientStatus"> Статус клиента банка </param>        
        BankCustomer CreateNewBankCustomer(Status clientStatus);
        
        /// <summary>
        /// Обновить данные клиента банка
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>        
        BankCustomer UpdateDataBankCustomer(IBankCustomer bankCustomer);
    }
}
