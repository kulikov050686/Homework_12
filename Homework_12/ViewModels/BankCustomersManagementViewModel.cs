using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class BankCustomersManagementViewModel : BaseClassViewModelINPC
    {
        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title { get; protected set; }

        /// <summary>
        /// Имя клиента
        /// </summary>
        public string NameCustomer { get; set; }

        /// <summary>
        /// Фамилия клиента
        /// </summary>
        public string SurnameCustomer { get; set; }

        /// <summary>
        /// Отчество клиента
        /// </summary>
        public string PatronymicCustomer { get; set; }

        /// <summary>
        /// Пол клиента
        /// </summary>
        public string GenderCustomer { get; set; }

        /// <summary>
        /// Дата рождения клиента
        /// </summary>
        public DateTime BirthdayCustomer { get; set; }

        /// <summary>
        /// Место рождения клиента
        /// </summary>
        public string PlaceOfBirthCustomer { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public BankCustomersManagementViewModel()
        {
            Title = "Клиента банка";
        }
    }
}
