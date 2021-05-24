using Models;
using System.Collections.Generic;

namespace Services
{
    /// <summary>
    /// 
    /// </summary>
    public class BankCustomersManager
    {
        #region Закрытые поля

        BankCustomerRepository _bankCustomers;
        DepartmentRepository _departments;

        #endregion

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<BankCustomer> BankCustomers => _bankCustomers.GetAll();

        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<Department<BankCustomer>> Departments => _departments.GetAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bankCustomerRepository"></param>
        /// <param name="departmentRepository"></param>
        public BankCustomersManager(BankCustomerRepository bankCustomerRepository, DepartmentRepository departmentRepository)
        {
            _bankCustomers = bankCustomerRepository;
            _departments = departmentRepository;
        }
    }
}
