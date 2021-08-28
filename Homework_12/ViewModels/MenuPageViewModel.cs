using Commands;
using Models;
using System.Collections.Generic;
using System.Windows.Input;

namespace ViewModels
{
    /// <summary>
    /// Модель-представление страицы с меню
    /// </summary>
    public class MenuPageViewModel : BaseClassViewModelINPC
    {
        #region Закрытые поля

        private readonly MainPageViewModel _mainPageViewModel = default!;

        #endregion

        /// <summary>
        /// Список всех департаментов банка
        /// </summary>
        public IEnumerable<Department> Departments => _mainPageViewModel.Departments;

        #region Команда сохранить в файл

        private ICommand _saveToFile = default!;
        public ICommand SaveToFile
        {
            get => _saveToFile ??= new RelayCommand((obj) =>
            {
                /// Сохранение в файл департаментов
            });
        }

        #endregion

        #region Команда создания нового клиента банка

        private ICommand _createNewBankCustomer = default!;
        public ICommand CreateNewBankCustomer
        {
            get => _createNewBankCustomer ??= new RelayCommand((obj) =>
            {
                _mainPageViewModel.CreateNewBankCustomer.Execute(_mainPageViewModel.SelectedDepartment);
            }, (obj) => _mainPageViewModel.SelectedDepartment != null);
        }

        #endregion

        #region Команда удаления клиента банка

        private ICommand _deleteBankCustomer = default!;
        public ICommand DeleteBankCustomer
        {
            get => _deleteBankCustomer ??= new RelayCommand((obj) =>
            {
                _mainPageViewModel.DeleteBankCustomer.Execute(_mainPageViewModel.SelectedBankCustomer);
            }, (obj) => _mainPageViewModel.SelectedBankCustomer != null);
        }

        #endregion

        #region Команда редактирования данных клиента банка

        private ICommand _editDataBankCustomer = default!;
        public ICommand EditDataBankCustomer
        {
            get => _editDataBankCustomer ??= new RelayCommand((obj) =>
            {
                _mainPageViewModel.EditDataBankCustomer.Execute(_mainPageViewModel.SelectedBankCustomer);
            }, (obj) => _mainPageViewModel.SelectedBankCustomer != null);
        }

        #endregion

        #region Команда создание нового депозитарного счёта

        private ICommand _createNewDepositoryAccount = default!;
        public ICommand CreateNewDepositoryAccount
        {
            get => _createNewDepositoryAccount ??= new RelayCommand((obj) =>
            {
                _mainPageViewModel.CreateNewDepositoryAccount.Execute(_mainPageViewModel.SelectedBankCustomer);
            }, (obj) => _mainPageViewModel.SelectedBankCustomer != null);
        }

        #endregion

        #region Команда удаления депозитарного счёта

        private ICommand _deleteDepositoryAccount = default!;
        public ICommand DeleteDepositoryAccount
        {
            get => _deleteDepositoryAccount ??= new RelayCommand((obj) =>
            {
                _mainPageViewModel.DeleteDepositoryAccount.Execute(_mainPageViewModel.SelectedDepositoryAccount);
            }, (obj) => _mainPageViewModel.SelectedDepositoryAccount != null);
        }

        #endregion

        #region Команда редактирования депозитарного счёта

        private ICommand _editDepositoryAccount = default!;
        public ICommand EditDepositoryAccount
        {
            get => _editDepositoryAccount ??= new RelayCommand((obj) =>
            {
                _mainPageViewModel.EditDepositoryAccount.Execute(_mainPageViewModel.SelectedDepositoryAccount);
            }, (obj) => _mainPageViewModel.SelectedDepositoryAccount != null);
        }

        #endregion

        #region Конструктор

        public MenuPageViewModel(MainPageViewModel mainPageViewModel)
        {
            _mainPageViewModel = mainPageViewModel;
        }

        #endregion
    }
}
