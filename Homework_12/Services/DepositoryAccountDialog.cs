using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using Views;

namespace Services
{
    /// <summary>
    /// Класс сервиса диалоговых окон по работе с депозитарным счётом
    /// </summary>
    public class DepositoryAccountDialog : IDepositoryAccountDialogService
    {
        /// <summary>
        /// Создание нового депозитарного счёта
        /// </summary>        
        public DepositoryAccount CreateNewDepositoryAccount()
        {
            var dialog = new AddDepositoryAccountWindow();

            if (dialog.ShowDialog() != true) return null;

            
            var interestRate = dialog.InterestRate;
            
            var depositoryAccount = new DepositoryAccount(0, dialog.SelectedDepositStatus);
            depositoryAccount.Amount = dialog.Amount;            
            depositoryAccount.InterestRate = dialog.InterestRate;

            return depositoryAccount;
        }

        /// <summary>
        /// Обновить данные депозитарного счёта
        /// </summary>
        /// <param name="depositoryAccount"> Депозитарный счёт </param>        
        public DepositoryAccount UpdateDataDepositoryAccount(DepositoryAccount depositoryAccount)
        {
            if(depositoryAccount is null)
                throw new ArgumentNullException("Депозитарный счёт не может быть null!!!");

            var dialog = new AddDepositoryAccountWindow();
            dialog.Amount = depositoryAccount.Amount;
            dialog.InterestRate = depositoryAccount.InterestRate;
            dialog.SelectedDepositStatus = depositoryAccount.DepositStatus;

            if (dialog.ShowDialog() != true) return null;

            var tempDepositoryAccount = new DepositoryAccount(depositoryAccount.Id, depositoryAccount.DepositStatus);
            tempDepositoryAccount.Amount = dialog.Amount;
            tempDepositoryAccount.InterestRate = dialog.InterestRate;
            tempDepositoryAccount.DepositStatus = dialog.SelectedDepositStatus;

            return tempDepositoryAccount;
        }

        /// <summary>
        /// Объединить депозитарные счета в один счёт
        /// </summary>
        /// <param name="depositoryAccounts"> Список депозитарных счетов </param>        
        public DepositoryAccount CombiningDepositoryAccounts(IEnumerable<DepositoryAccount> depositoryAccounts)
        {
            if(depositoryAccounts is null)
                throw new ArgumentNullException("Список счетов не может быть null!!!");

            var dialog = new SelectedBankAccountWindow();
            dialog.BankAccounts = depositoryAccounts;

            if (dialog.ShowDialog() != true) return null;

            return (DepositoryAccount)dialog.SelectedBankAccount;
        }
    }
}
