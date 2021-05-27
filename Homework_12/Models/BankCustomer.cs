using Enums;
using Interfaces;
using System;

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
        /// Конструктор
        /// </summary>
        /// <param name="passport"> Паспорт </param>
        /// <param name="clientStatus"> Статус </param>
        /// <param name="phoneNumber"> Номер телефона </param>
        public BankCustomer(IPassport passport,
                            ClientStatus clientStatus,
                            string phoneNumber)
        {
            if(passport is null) throw new ArgumentException("");
            if(string.IsNullOrWhiteSpace(phoneNumber)) throw new ArgumentException("");

            Passport = passport;
            ClientStatus = clientStatus;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="passport"> Паспорт </param>
        /// <param name="clientStatus"> Статус </param>
        /// <param name="phoneNumber"> Номер телефон </param>
        /// <param name="reliability"> Надёжность </param>
        public BankCustomer(IPassport passport,
                            ClientStatus clientStatus,
                            string phoneNumber,
                            byte reliability) : this(passport,
                                                     clientStatus,
                                                     phoneNumber)
        {
            Reliability = reliability;
        }

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
                            string phoneNumber,
                            byte reliability,
                            string email) : this(passport,
                                                 clientStatus,
                                                 phoneNumber,
                                                 reliability)
        {
            if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("");
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
                            string phoneNumber,
                            byte reliability,
                            string email) : this(passport,
                                                 clientStatus,
                                                 phoneNumber,
                                                 reliability,
                                                 email)
        {
            if(id < 0) throw new ArgumentException("");
            Id = id;
        }
    }
}
