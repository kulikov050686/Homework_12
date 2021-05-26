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
        private Department<BankCustomer> _selectedDepartment;
        private BankCustomer _selectedBankCustomer;

        #endregion

        #region Открытые свойства

        /// <summary>
        /// Список всех клиентов банка
        /// </summary>
        public IEnumerable<BankCustomer> BankCustomers => _bankCustomersManager.BankCustomers;

        /// <summary>
        /// Список всех департаментов банка
        /// </summary>
        public IEnumerable<Department<BankCustomer>> Departments => _bankCustomersManager.Departments;

        /// <summary>
        /// Выбранный департамент
        /// </summary>
        public Department<BankCustomer> SelectedDepartment
        {
            get => _selectedDepartment;
            set => Set(ref _selectedDepartment, value);
        }

        /// <summary>
        /// Выбранный клиент
        /// </summary>
        public BankCustomer SelectedBankCustomer
        {
            get => _selectedBankCustomer;
            set => Set(ref _selectedBankCustomer, value);
        }

        #endregion

        #region Конструктор

        public MainPageViewModel(BankCustomersManager bankCustomersManager)
        {
            _bankCustomersManager = bankCustomersManager;
        }

        #endregion
    }
}
