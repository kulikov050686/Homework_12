using Models;
using System.Collections.Generic;
using System;

namespace Services
{
    /// <summary>
    /// Менеджер депозитарного счёта
    /// </summary>
    public class DepositoryAccountsManager
    {
        #region Закрытые поля

        DepositoryAccountRepository _depositoryAccounts;
        BankCustomerRepository _bankCustomers;

        #endregion

        /// <summary>
        /// Получить список всех депозитарных счетов клиентов банка
        /// </summary>
        public IEnumerable<DepositoryAccount> DepositoryAccounts => _depositoryAccounts.GetAll();

        /// <summary>
        /// Обновление данных депозитарного счёта клиента банка и сохранение в репозитории
        /// </summary>
        /// <param name="depositoryAccount"> Депозитарный счёт </param>
        public void Update(DepositoryAccount depositoryAccount)
        {
            _depositoryAccounts.Update(depositoryAccount.Id, depositoryAccount);
        }

        /// <summary>
        /// Добавить новый депозотарный счёт клиенту банка
        /// </summary>
        /// <param name="depositoryAccount"> Депозитарный счёт </param>
        /// <param name="bankCustomer"> Клиент банка </param>        
        public bool CreateNewDepositoryAccount(DepositoryAccount depositoryAccount, BankCustomer bankCustomer)
        {
            if (bankCustomer is null)
                throw new ArgumentNullException(nameof(bankCustomer), "Клиент банка не может быть null!!!");
            if (depositoryAccount is null)
                throw new ArgumentNullException(nameof(depositoryAccount), "Счёт не может быть null!!!");

            var selectedBankCustomer = _bankCustomers.Get(bankCustomer.Id);
            if (selectedBankCustomer is null) return false;

            bankCustomer.DepositoryAccounts.Add(depositoryAccount);
            _depositoryAccounts.Add(depositoryAccount);

            return true;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="depositoryAccountRepository"> Хранилище депозитарных счетов клиентов банка </param>
        /// <param name="bankCustomerRepository"> Хранилище клиентов банка </param>
        public DepositoryAccountsManager(DepositoryAccountRepository depositoryAccountRepository,
                                         BankCustomerRepository bankCustomerRepository)
        {
            _bankCustomers = bankCustomerRepository;
            _depositoryAccounts = depositoryAccountRepository;
        }
    }
}
