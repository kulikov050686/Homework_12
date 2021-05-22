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
        /// Конструктор
        /// </summary>
        public BankCustomersManagementViewModel()
        {
            Title = "Клиента банка";
        }
    }
}
