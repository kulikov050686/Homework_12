using System;

namespace Models
{
    /// <summary>
    /// Базавый класс банковский счёт
    /// </summary>
    public class BankAccountBaseClass
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public ulong Id { get; set; }
        
        /// <summary>
        /// Сумма на счёте
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// Процентная ставка
        /// </summary>
        public double InterestRate { get; set; }

        /// <summary>
        /// Статус счёта
        /// </summary>
        public AccountStatus AccountStatus { get; protected set; }

        /// <summary>
        /// Клиент банка
        /// </summary>
        public BankCustomerBaseClass BankCustomer { get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>
        /// <param name="accountStatus"> Статус счёта </param>
        public BankAccountBaseClass(BankCustomerBaseClass bankCustomer, AccountStatus accountStatus)
        {
            if (bankCustomer is null) throw new ArgumentException("");

            BankCustomer = bankCustomer;
            AccountStatus = accountStatus;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>
        public BankAccountBaseClass(BankCustomerBaseClass bankCustomer)
        {
            if (bankCustomer is null) throw new ArgumentException("");

            BankCustomer = bankCustomer;
        }
    }
}
