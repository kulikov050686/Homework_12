using Enums;
using Models;
using System.Collections.Generic;

namespace Interfaces
{
    /// <summary>
    /// Интерфейс Клиет Банка
    /// </summary>
    public interface IBankCustomer : IEntity
    {
        /// <summary>
        /// Паспорт
        /// </summary>
        IPassport Passport { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        ClientStatus ClientStatus { get; set; }

        /// <summary>
        /// Надёжность
        /// </summary>
        byte Reliability { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        string PhoneNumber { get; set; }

        /// <summary>
        /// Адрес электронной почты
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Лист счетов
        /// </summary>
        IList<BankAccount> BankAccounts { get; set; }
    }
}
