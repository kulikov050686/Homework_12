using Commands;
using Interfaces;
using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Input;

namespace ViewModels
{
    /// <summary>
    /// Модель-представление главной страницы
    /// </summary>
    public class MainPageViewModel : BaseClassViewModelINPC
    {
        #region Закрытые поля

        private readonly BankCustomersManager _bankCustomersManager;
        private readonly DepositoryAccountsManager _depositoryAccountsManager;
        private Department _selectedDepartment;
        private BankCustomer _selectedBankCustomer;
        private DepositoryAccount _selectedDepositoryAccount;
        private IBankCustomerDialogService _bankCustomerDialog;
        private Timer _timer;

        #endregion

        #region Открытые свойства
        
        /// <summary>
        /// Список всех департаментов банка
        /// </summary>
        public IEnumerable<Department> Departments => _bankCustomersManager.Departments;

        /// <summary>
        /// Список всех клиентов банка
        /// </summary>
        public IEnumerable<BankCustomer> BankCustomers => _bankCustomersManager.BankCustomers;

        /// <summary>
        /// Список всех депозитарных счетов
        /// </summary>
        public IEnumerable<DepositoryAccount> DepositoryAccounts => _depositoryAccountsManager.DepositoryAccounts;

        /// <summary>
        /// Выбранный департамент
        /// </summary>
        public Department SelectedDepartment
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

        /// <summary>
        /// Выбранный дпозитарный счёт
        /// </summary>
        public DepositoryAccount SelectedDepositoryAccount
        {
            get => _selectedDepositoryAccount;
            set => Set(ref _selectedDepositoryAccount, value);
        }

        #endregion

        #region Команда создания нового клиента банка

        private ICommand _createNewBankCustomer;
        public ICommand CreateNewBankCustomer
        {
            get => _createNewBankCustomer ??= new RelayCommand((obj) =>
            {
                var department = (Department)obj;
                var bankCustomer = _bankCustomerDialog.CreateNewBankCustomer(department.StatusDepartment);

                if (bankCustomer is null) return;
                _bankCustomersManager.CreateNewBankCustomer(bankCustomer, department);                
            }, (obj) => obj is Department);
        }

        #endregion

        #region Команда удаления клиента банка

        private ICommand _deleteBankCustomer;
        public ICommand DeleteBankCustomer
        {
            get => _deleteBankCustomer ??= new RelayCommand((obj) =>
            {
                var department = SelectedDepartment;
                var bankCustomer = SelectedBankCustomer;

                if (department is null || bankCustomer is null) return;
                _bankCustomersManager.DeleteBankCustomer(bankCustomer, department);                
            }, (obj) => obj is BankCustomer);
        }

        #endregion

        #region Команда редактирования данных клиента банка

        private ICommand _editDataBankCustomer;
        public ICommand EditDataBankCustomer
        {
            get => _editDataBankCustomer ??= new RelayCommand((obj) =>
            {
                var bankCustomer = (BankCustomer)obj;
                if (bankCustomer is null) return;

                var tempBankCustomer = _bankCustomerDialog.UpdateDataBankCustomer(bankCustomer);
                if (tempBankCustomer is null) return;                

                _bankCustomersManager.Update(tempBankCustomer);                
            }, (obj) => obj is BankCustomer);
        }

        #endregion

        #region Конструктор

        public MainPageViewModel(BankCustomersManager bankCustomersManager, 
                                 DepositoryAccountsManager depositoryAccountsManager, 
                                 IBankCustomerDialogService bankCustomerDialog)
        {
            _bankCustomersManager = bankCustomersManager;
            _bankCustomerDialog = bankCustomerDialog;
            _depositoryAccountsManager = depositoryAccountsManager;

            TimerCallback tm = new TimerCallback(UpdatingData);
            _timer = new Timer(tm, 0, 0, 2000);
        }

        #endregion

        #region Закрытые методы

        private void UpdatingData(object state)
        {
            
        }

        #endregion
    }
}
