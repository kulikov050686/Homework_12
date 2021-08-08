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
        /// Описание
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Лист счетов
        /// </summary>
        IList<BankAccount> BankAccounts { get; set; }

        /// <summary>
        /// Метод сравнения
        /// </summary>
        /// <param name="obj"> Сравниваемый объект </param>
        bool Equals(IBankCustomer obj)
        {
            if (obj is null) return false;

            bool key = true;

            if((BankAccounts == null && obj.BankAccounts != null) ||
               (BankAccounts != null && obj.BankAccounts == null))
            {
                key = false;
            }

            if((BankAccounts != null) && (obj.BankAccounts != null) && key)
            {
                if(BankAccounts.Count == obj.BankAccounts.Count)
                {
                    for(int i = 0; i < BankAccounts.Count && key; i++)
                    {
                        key = key && BankAccounts[i].Equals(obj.BankAccounts[i]);
                    }
                }
                else
                {
                    key = false;
                }
            }

            if (!key) return false;

            return (Id == obj.Id) &&
                   Passport.Equals(obj.Passport) &&
                   ClientStatus == obj.ClientStatus &&
                   Reliability == obj.Reliability &&
                   PhoneNumber == obj.PhoneNumber &&
                   Email == obj.Email;
        }
    }
}
