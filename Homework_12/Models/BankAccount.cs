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
        public AccountStatus AccountStatus { get; set; }               

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="id"> Идентификатор </param>        
        /// <param name="accountStatus"> Статус счёта </param>
        public BankAccount(int id, AccountStatus accountStatus)
        {
            if (id < 0) 
                throw new ArgumentException("Невозможный идентификатор!!!");

            Id = id;
            AccountStatus = accountStatus;
        }
    }
}
