using Enums;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Models
{
    /// <summary>
    /// Базовый класс Клиент Банка
    /// </summary>
    public class BankCustomer : IBankCustomer
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Паспорт
        /// </summary>
        public IPassport Passport { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public ClientStatus ClientStatus { get; set; }

        /// <summary>
        /// Надёжность
        /// </summary>
        public byte Reliability { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Адрес электронной почты
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Список счетов
        /// </summary>
        public IList<BankAccount> BankAccounts { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="passport"> Паспорт </param>
        /// <param name="clientStatus"> Статус </param>
        /// <param name="phoneNumber"> Номер телефона </param>
        /// <param name="reliability"> Надёжность </param>
        /// <param name="email"> Электронная почта </param>
        public BankCustomer(IPassport passport,
                            ClientStatus clientStatus,
                            string phoneNumber = "",
                            byte reliability = 0,
                            string email = "")
        {
            if (passport is null) throw new ArgumentNullException("Паспорт не может быть null!!!");
            Passport = passport;
            ClientStatus = clientStatus;

            PhoneNumber = phoneNumber;
            Reliability = reliability;
            Email = email;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="id"> Идентификатор </param>
        /// <param name="passport"> Паспорт </param>
        /// <param name="clientStatus"> Статус </param>
        /// <param name="phoneNumber"> Номер телефон </param>
        /// <param name="reliability"> Надёжность </param>
        /// <param name="email"> Электронная почта </param>
        public BankCustomer(int id,
                            IPassport passport,
                            ClientStatus clientStatus,
                            string phoneNumber = "",
                            byte reliability = 0,
                            string email = "") : this(passport,
                                                 clientStatus,
                                                 phoneNumber,
                                                 reliability,
                                                 email)
        {
            if(id < 0) throw new ArgumentException("Невозможный идентификатор!!!");
            Id = id;
        }
    }
}
