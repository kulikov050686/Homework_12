using Models;
using System.Collections.Generic;
using System;

namespace Services
{
    /// <summary>
    /// Менеджер счетов клиентов банка
    /// </summary>
    public class BankAccountManager
    {
        #region Закрытые поля

        BankAccountRepository _bankAccounts;
        BankCustomerRepository _bankCustomers;

        #endregion

        /// <summary>
        /// Получить список всех счетов
        /// </summary>
        public IEnumerable<BankAccount> BankAccounts => _bankAccounts.GetAll();

        /// <summary>
        /// Обновление данных счёта и сохранение в репозитории
        /// </summary>
        /// <param name="bankAccount"> Счёт </param>
        public void Update(BankAccount bankAccount)
        {
            _bankAccounts.Update(bankAccount.Id, bankAccount);
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="bankAccountRepository"> Хранилище счетов клиентов банка </param>
        /// <param name="bankCustomerRepository"> Хранилище клиентов банка </param>
        public BankAccountManager(BankAccountRepository bankAccountRepository, 
                                  BankCustomerRepository bankCustomerRepository)
        {
            _bankAccounts = bankAccountRepository;
            _bankCustomers = bankCustomerRepository;
        }
    }
}
