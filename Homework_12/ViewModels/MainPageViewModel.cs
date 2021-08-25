using Commands;
using Enums;
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
        private IDepositoryAccountDialogService _depositoryAccountDialog;
        private int _k = 1;
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

        #region Команда создание нового депозитарного счёта

        private ICommand _createNewDepositoryAccount;
        public ICommand CreateNewDepositoryAccount
        {
            get => _createNewDepositoryAccount ??= new RelayCommand((obj) =>
            {
                var bankCustomer = (BankCustomer)obj;
                var depositoryAccount = _depositoryAccountDialog.CreateNewDepositoryAccount();

                if (depositoryAccount is null) return;
                _depositoryAccountsManager.CreateNewDepositoryAccount(depositoryAccount, bankCustomer);

            }, (obj) => obj is BankCustomer);
        }

        #endregion

        #region Команда удаления депозитарного счёта

        private ICommand _deleteDepositoryAccount;
        public ICommand DeleteDepositoryAccount
        {
            get => _deleteDepositoryAccount ??= new RelayCommand((obj) => 
            {
                var bankCustomer = SelectedBankCustomer;
                var depositoryAccount = SelectedDepositoryAccount;

                if (bankCustomer is null || depositoryAccount is null) return;
                _depositoryAccountsManager.DeleteDepositoryAccount(depositoryAccount, bankCustomer);
            }, (obj) => obj is DepositoryAccount);
        }

        #endregion

        #region Команда редактирования депозитарного счёта

        private ICommand _editDepositoryAccount;
        public ICommand EditDepositoryAccount
        {
            get => _editDepositoryAccount ??= new RelayCommand((obj) =>
            {
                var depositoryAccount = (DepositoryAccount)obj;
                if (depositoryAccount is null) return;

                var tempDepositoryAccount = _depositoryAccountDialog.UpdateDataDepositoryAccount(depositoryAccount);
                if (tempDepositoryAccount is null) return;

                _depositoryAccountsManager.Update(tempDepositoryAccount);
            }, (obj) => obj is DepositoryAccount);
        }

        #endregion

        #region Команда объединения депозитарных счетов

        private ICommand _combiningDepositoryAccounts;
        public ICommand CombiningDepositoryAccounts
        {
            get => _combiningDepositoryAccounts ??= new RelayCommand((obj) => 
            {
                var depositoryAccount = (DepositoryAccount)obj;
                if (depositoryAccount is null) return;

                var tempDepositoryAccount = _depositoryAccountDialog.CombiningDepositoryAccounts(SelectedBankCustomer.DepositoryAccounts);
                if (tempDepositoryAccount is null) return;

                if (!_depositoryAccountsManager.CombiningDepositoryAccounts(depositoryAccount, tempDepositoryAccount, SelectedBankCustomer)) return;

            }, (obj) => obj is DepositoryAccount);
        }

        #endregion

        #region Конструктор

        public MainPageViewModel(BankCustomersManager bankCustomersManager, 
                                 DepositoryAccountsManager depositoryAccountsManager, 
                                 IBankCustomerDialogService bankCustomerDialog,
                                 IDepositoryAccountDialogService depositoryAccountDialogService)
        {
            _bankCustomersManager = bankCustomersManager;
            _bankCustomerDialog = bankCustomerDialog;
            _depositoryAccountsManager = depositoryAccountsManager;
            _depositoryAccountDialog = depositoryAccountDialogService;

            TimerCallback tm = new TimerCallback(UpdatingData);
            _timer = new Timer(tm, 0, 0, 2000);
        }

        #endregion

        #region Закрытые методы

        private void UpdatingData(object state)
        {
            foreach (var item in DepositoryAccounts)
            {
                if(item.DepositStatus == DepositStatus.WITHOUTCAPITALIZATION && _k == 12)
                {
                    item.Amount = item.Amount * (1 + item.InterestRate / 100);                                       
                }

                if(item.DepositStatus == DepositStatus.WITHCAPITALIZATION)
                {                  
                    item.Amount = item.Amount * (1 + item.InterestRate / 1200);
                }
            }

            if(_k == 12)
            {
                _k = 1;
            }
            else
            {
                _k++;
            }
        }

        #endregion
    }
}
