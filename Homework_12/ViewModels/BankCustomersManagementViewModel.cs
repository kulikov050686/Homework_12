using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class BankCustomersManagementViewModel : BaseClassViewModelINPC
    {
        #region Закрытые поля

        private readonly BankCustomersManager _bankCustomersManager;

        #endregion

        #region Открытые поля

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

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        public BankCustomersManagementViewModel(BankCustomersManager bankCustomersManager)
        {
            Title = "Клиента банка";
            _bankCustomersManager = bankCustomersManager;
        }

        #endregion
    }
}
