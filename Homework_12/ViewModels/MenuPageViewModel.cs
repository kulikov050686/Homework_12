using Commands;
using Models;
using Services;
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

        private readonly MainPageViewModel _mainPageViewModel;

        #endregion

        /// <summary>
        /// Список всех департаментов банка
        /// </summary>
        public IEnumerable<Department> Departments => _mainPageViewModel.Departments;

        #region Команда сохранить в файл

        private ICommand _saveToFile;
        public ICommand SaveToFile
        {
            get => _saveToFile ??= new RelayCommand((obj) =>
            {
                /// Сохранение в файл департаментов
            });
        }

        #endregion

        #region Команда создания нового клиента банка

        private ICommand _createNewBankCustomer;
        public ICommand CreateNewBankCustomer
        {
            get => _createNewBankCustomer ??= new RelayCommand((obj) =>
            {
                _mainPageViewModel.CreateNewBankCustomer.Execute(_mainPageViewModel.SelectedDepartment);
            }, (obj) => _mainPageViewModel.SelectedDepartment != null);
        }

        #endregion

        #region Команда удаления клиента банка

        private ICommand _deleteBankCustomer;
        public ICommand DeleteBankCustomer
        {
            get => _deleteBankCustomer ??= new RelayCommand((obj) =>
            {
                _mainPageViewModel.DeleteBankCustomer.Execute(_mainPageViewModel.SelectedBankCustomer);
            }, (obj) => _mainPageViewModel.SelectedBankCustomer != null);
        }

        #endregion

        #region Команда редактирования данных клиента банка

        private ICommand _editDataBankCustomer;
        public ICommand EditDataBankCustomer
        {
            get => _editDataBankCustomer ??= new RelayCommand((obj) =>
            {
                _mainPageViewModel.EditDataBankCustomer.Execute(_mainPageViewModel.SelectedBankCustomer);
            }, (obj) => _mainPageViewModel.SelectedBankCustomer != null);
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
