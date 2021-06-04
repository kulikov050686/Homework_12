using Models;
using System.Collections.Generic;

namespace Services
{
    /// <summary>
    /// Менеджер Клиента банка
    /// </summary>
    public class BankCustomersManager
    {
        #region Закрытые поля

        BankCustomerRepository _bankCustomers;
        DepartmentRepository _departments;

        #endregion

        /// <summary>
        /// Получить список всех клиентов
        /// </summary>
        public IEnumerable<BankCustomer> BankCustomers => _bankCustomers.GetAll();

        /// <summary>
        /// Получить список всех департаментов
        /// </summary>
        public IEnumerable<Department> Departments => _departments.GetAll();

        /// <summary>
        /// Обновление данных клиента банка и сохранение в репозитории
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>
        public void Update(BankCustomer bankCustomer)
        {
            _bankCustomers.Update(bankCustomer.Id, bankCustomer);
        }

        /// <summary>
        /// Добавление нового клиента банка в департамент
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>
        /// <param name="department"> Департамент </param>
        /// <returns></returns>
        public bool Create(BankCustomer bankCustomer, Department department)
        {
            return false;
        }
         
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="bankCustomerRepository"> Хранилище клиентов банка </param>
        /// <param name="departmentRepository"> Хранилище департаментов банка </param>
        public BankCustomersManager(BankCustomerRepository bankCustomerRepository, DepartmentRepository departmentRepository)
        {
            _bankCustomers = bankCustomerRepository;
            _departments = departmentRepository;
        }
    }
}
