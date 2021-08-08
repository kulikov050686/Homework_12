using Commands;
using Enums;
using Interfaces;
using Models;
using Services;
using System.Collections.Generic;
using System.Windows.Input;

namespace ViewModels
{
    public class MainPageViewModel : BaseClassViewModelINPC
    {
        #region Закрытые поля

        private readonly BankCustomersManager _bankCustomersManager;
        private Department _selectedDepartment;
        private BankCustomer _selectedBankCustomer;
        private IBankCustomerDialogService _bankCustomerDialog;

        #endregion

        #region Открытые свойства

        /// <summary>
        /// Список всех клиентов банка
        /// </summary>
        public IEnumerable<BankCustomer> BankCustomers => _bankCustomersManager.BankCustomers;

        /// <summary>
        /// Список всех департаментов банка
        /// </summary>
        public IEnumerable<Department> Departments => _bankCustomersManager.Departments;

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

        #endregion

        #region Команда создания нового клиента банка

        private ICommand _createNewBankCustomer;
        public ICommand CreateNewBankCustomer
        {
            get => _createNewBankCustomer ??= new RelayCommand((obj) =>
            {
                var department = (Department)obj;
                var bankCustomer = _bankCustomerDialog.CreateNewBankCustomer(ClientStatus.LEGAL);

                if (bankCustomer is null) return;

                if(_bankCustomersManager.CreateNewBankCustomer(bankCustomer, department))
                {
                    OnPropertyChanged(nameof(BankCustomers));                    
                }
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

                if(_bankCustomersManager.DeleteBankCustomer(bankCustomer, department))
                {
                    OnPropertyChanged(nameof(BankCustomers));
                }

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
                OnPropertyChanged(nameof(BankCustomers));
            }, (obj) => obj is BankCustomer);
        }

        #endregion

        #region Конструктор

        public MainPageViewModel(BankCustomersManager bankCustomersManager,
                                 IBankCustomerDialogService bankCustomerDialog)
        {
            _bankCustomersManager = bankCustomersManager;
            _bankCustomerDialog = bankCustomerDialog;
        }

        #endregion
    }
}
