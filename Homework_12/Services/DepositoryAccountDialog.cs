using Enums;
using Interfaces;
using Models;
using System;
using Views;

namespace Services
{
    public class DepositoryAccountDialog : IDepositoryAccountDialogService
    {
        /// <summary>
        /// 
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
    }
}
