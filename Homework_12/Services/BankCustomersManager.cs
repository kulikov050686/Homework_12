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
        public IEnumerable<Department<BankCustomer>> Departments => _departments.GetAll();
         
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
