using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class MainPageViewModel : BaseClassViewModelINPC
    {
        #region Закрытые поля

        private readonly BankCustomersManager _bankCustomersManager;

        #endregion

        #region Открытые свойства

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<BankCustomer> BankCustomers => _bankCustomersManager.BankCustomers;

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Department<BankCustomer>> Departments => _bankCustomersManager.Departments;

        #endregion

        #region Конструктор

        public MainPageViewModel(BankCustomersManager bankCustomersManager)
        {
            _bankCustomersManager = bankCustomersManager;
        }

        #endregion
    }
}
