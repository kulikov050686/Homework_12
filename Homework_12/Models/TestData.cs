using Enums;
using System;
using System.Linq;

namespace Models
{
    /// <summary>
    /// Тестовые данные
    /// </summary>
    public static class TestData
    {
        /// <summary>
        /// Департаменты банка
        /// </summary>
        public static Department[] Departments = Enumerable.Range(1, 10).Select(i => new Department($"Департамент {i}")).ToArray();       

        /// <summary>
        /// Клиенты банка
        /// </summary>
        public static BankCustomer[] BankCustomers = CreateBankCustomers(Departments);
        
        /// <summary>
        /// Заполнение клиентами банка депортаментов
        /// </summary>
        /// <param name="departments"> Департаменты </param>        
        private static BankCustomer[] CreateBankCustomers(Department[] departments)
        {
            var index = 1;            

            foreach (var item in departments)
            {
                for (int i = 0; i < 10; i++)
                {
                    item.BankCustomers.Add(new BankCustomer(new Passport(111,
                                                                         222222,
                                                                         $"Место выдачи {index}",
                                                                         DateTime.Today,
                                                                         333333,
                                                                         new Person($"Фамилия {index}",
                                                                                    $"Имя {index}",
                                                                                    $"Отчество {index}",
                                                                                    $"муж",
                                                                                    DateTime.Today,
                                                                                    $"Место рождения {index}",
                                                                                    new Address(DateTime.Today,
                                                                                                $"Регион {index}",
                                                                                                $"Город {index}",
                                                                                                $"Улица {index}",
                                                                                                100 + index))),
                                                            ClientStatus.LEGAL,
                                                            $"0123-456-789"));
                    index++;
                }
            }
           
            return departments.SelectMany(d => d.BankCustomers).ToArray();
        }
    }
}
