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
        /// Добавить новый депозотарный счёт
        /// </summary>
        /// <param name="depositoryAccount"> Депозитарный счёт </param>
        /// <param name="bankCustomer"> Клиент банка </param>        
        public bool CreateNewDepositoryAccount(DepositoryAccount depositoryAccount, 
                                               BankCustomer bankCustomer)
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
        /// Удалить депозотарный счёт
        /// </summary>
        /// <param name="depositoryAccount"> Депозитарный счёт </param>
        /// <param name="bankCustomer"> Клиент банка </param>        
        public bool DeleteDepositoryAccount(DepositoryAccount depositoryAccount, 
                                            BankCustomer bankCustomer)
        {
            if (bankCustomer is null)
                throw new ArgumentNullException(nameof(bankCustomer), "Клиент банка не может быть null!!!");
            if (depositoryAccount is null)
                throw new ArgumentNullException(nameof(depositoryAccount), "Счёт не может быть null!!!");

            var selectedBankCustomer = _bankCustomers.Get(bankCustomer.Id);
            if (selectedBankCustomer is null) return false;

            if(bankCustomer.DepositoryAccounts.Remove(depositoryAccount))
            {
                _depositoryAccounts.Remove(depositoryAccount);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Объединение депозитарных счетов
        /// </summary>
        /// <param name="depositoryAccount1"> Депозитарный счёт 1 </param>
        /// <param name="depositoryAccount2"> Депозитарный счёт 2 </param>
        /// <param name="bankCustomer"> Клиент банка </param>        
        public bool CombiningDepositoryAccounts(DepositoryAccount depositoryAccount1, 
                                                DepositoryAccount depositoryAccount2, 
                                                BankCustomer bankCustomer)
        {
            if(depositoryAccount1 is null)
                throw new ArgumentNullException(nameof(depositoryAccount1), "Счёт не может быть null!!!");
            if(depositoryAccount2 is null)
                throw new ArgumentNullException(nameof(depositoryAccount2), "Счёт не может быть null!!!");
            if (bankCustomer is null)
                throw new ArgumentNullException(nameof(bankCustomer), "Клиент банка не может быть null!!!");

            var selectedBankCustomer = _bankCustomers.Get(bankCustomer.Id);
            if (selectedBankCustomer is null) return false;            

            var selectedDepositoryAccount1 = _depositoryAccounts.Get(depositoryAccount1.Id);
            if (selectedDepositoryAccount1 is null) return false;

            var selectedDepositoryAccount2 = _depositoryAccounts.Get(depositoryAccount2.Id);
            if (selectedDepositoryAccount2 is null) return false;

            if (selectedDepositoryAccount1.Id == selectedDepositoryAccount2.Id) return false;

            selectedDepositoryAccount1.Amount += selectedDepositoryAccount2.Amount;
            
            return DeleteDepositoryAccount(depositoryAccount2, bankCustomer);
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
