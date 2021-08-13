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
        public static Department[] Departments = CreateDepartments();

        /// <summary>
        /// Клиенты банка
        /// </summary>
        public static BankCustomer[] BankCustomers = CreateBankCustomers(Departments);

        /// <summary>
        /// Депозитарные счета клиентов банка
        /// </summary>
        public static DepositoryAccount[] DepositoryAccount = CreateDepositoryAccount(BankCustomers);               
        
        /// <summary>
        /// Создание департаментов банка
        /// </summary>        
        private static Department[] CreateDepartments()
        {
            Department[] departments = new Department[3];

            for(int i = 0; i < 3; i++)
            {
                if(i == 0)
                    departments[i] = new Department(i, $"Департамент { i }", Status.USUAL);
                if(i == 1)
                    departments[i] = new Department(i, $"Департамент { i }", Status.VIP);
                if(i == 2)
                    departments[i] = new Department(i, $"Департамент { i }", Status.JURIDICAL);
            }

            return departments;
        }

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
                    var address = new Address(DateTime.Today, $"Регион {index}", $"Город {index}", $"Улица {index}", 100 + index);
                    var person = new Person($"Фамилия {index}", $"Имя {index}", $"Отчество {index}", $"муж", DateTime.Today, $"Место рождения {index}", address);
                    var divisionCode = new DivisionCode(200 + index, 300 + index);
                    var pasport = new Passport(111, 222222, $"Место выдачи {index}", DateTime.Today, divisionCode, person);

                    var bankCustomer = new BankCustomer(index, pasport, item.StatusDepartment, $"0123-456-789");

                    item.BankCustomers.Add(bankCustomer);
                    index++;
                }
            }

            return departments.SelectMany(d => d.BankCustomers).ToArray();
        }

        /// <summary>
        /// Заполнение депозитарными счетами клиентов банка
        /// </summary>
        /// <param name="bankCustomers"> Клиенты банка </param>        
        private static DepositoryAccount[] CreateDepositoryAccount(BankCustomer[] bankCustomers)
        {
            var index = 1;

            foreach (var item in bankCustomers)
            {
                for(int i = 0; i < 3; i++)
                {
                    var bankAccount = new DepositoryAccount(index, DepositStatus.WITHOUTCAPITALIZATION);

                    bankAccount.Amount = 1000;
                    bankAccount.InterestRate = 10;

                    item.DepositoryAccounts.Add(bankAccount);
                    index++;
                }
            }

            return bankCustomers.SelectMany(d => d.DepositoryAccounts).ToArray();
        }
    }
}
