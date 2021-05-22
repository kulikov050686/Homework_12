using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class BankCustomersManager
    {
        private BankCustomerRepository _bankCustomers;
        DepartmentRepository _departments;

        public IEnumerable<BankCustomer> BankCustomers => _bankCustomers.GetAll();

        public IEnumerable<Department<BankCustomer>> Departments => _departments.GetAll();

        public BankCustomersManager(BankCustomerRepository bankCustomerRepository, DepartmentRepository departmentRepository)
        {
            _bankCustomers = bankCustomerRepository;
            _departments = departmentRepository;
        }
    }
}
