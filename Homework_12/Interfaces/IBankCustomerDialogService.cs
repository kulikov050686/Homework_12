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
        BankCustomer CreateNewBankCustomer(ClientStatus clientStatus);
        
        /// <summary>
        /// Заменить паспорт
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>
        Passport ReplacePassport(IBankCustomer bankCustomer);

        /// <summary>
        /// Добавить описание
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>
        void AddDescription(IBankCustomer bankCustomer);

        /// <summary>
        /// Добавить электронный адрес 
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>
        void AddEmail(IBankCustomer bankCustomer);

        /// <summary>
        /// Добавить номер телефона
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>
        void AddPhoneNumber(IBankCustomer bankCustomer);

        /// <summary>
        /// Изменить надёжность клиента банка
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>
        void ChangeReliability(IBankCustomer bankCustomer);
    }
}
