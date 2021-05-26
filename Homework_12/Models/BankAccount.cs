using Enums;
using Interfaces;
using System;

namespace Models
{
    /// <summary>
    /// Базавый класс банковский счёт
    /// </summary>
    public class BankAccount : IBankAccount
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        
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
        public IBankCustomer BankCustomer { get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>
        public BankAccount(IBankCustomer bankCustomer)
        {
            if (bankCustomer is null) throw new ArgumentException("");
            BankCustomer = bankCustomer;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>
        /// <param name="accountStatus"> Статус счёта </param>
        public BankAccount(IBankCustomer bankCustomer, AccountStatus accountStatus) : this(bankCustomer)
        {
            AccountStatus = accountStatus;
        }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="id"> Идентификатор </param>
        /// <param name="bankCustomer"> Клиент банка </param>
        /// <param name="accountStatus"> Статус счёта </param>
        public BankAccount(int id, IBankCustomer bankCustomer, AccountStatus accountStatus) : this(bankCustomer, accountStatus)
        {
            if (id < 0) throw new ArgumentException("");
            Id = id;
        }
    }
}
