using Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class TestData
    {
        /// <summary>
        /// Департаменты банка
        /// </summary>
        public IEnumerable<Department<BankCustomer>> Departments
        {
            get
            {
                return Enumerable.Range(1, 10).Select(i => new Department<BankCustomer>($"Департамент {i}"));
            }
        }

        /// <summary>
        /// Клиенты банка
        /// </summary>
        public IEnumerable<BankCustomer> BankCustomers
        {
            get
            {
                return Enumerable.Range(1, 10).Select(i => new BankCustomer(new Passport(111, 
                                                                                         222222, 
                                                                                         "Место выдачи", 
                                                                                         DateTime.Now, 
                                                                                         333333, 
                                                                                         new Person($"Фамилия {i}", 
                                                                                                    $"Имя {i}", 
                                                                                                    $"Отчество {i}", 
                                                                                                    $"муж", 
                                                                                                    DateTime.Now, 
                                                                                                    "Место рождения", 
                                                                                                    new Address(DateTime.Now, 
                                                                                                                $"Регион {i}", 
                                                                                                                $"Город {i}", 
                                                                                                                $"Улица {i}", 
                                                                                                                100 + i))), 
                                                                            ClientStatus.LEGAL, 
                                                                            $"0123-456-789"));
            }
        }
    }
}
