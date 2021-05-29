using Interfaces;
using Models;
using System;
using System.Windows;
using Views;

namespace Services
{
    /// <summary>
    /// Класс сервиса для взаимодействия с пользователем с помощью окон
    /// </summary>
    public class WindowUserDialogService : IUserDialogService
    {
        public bool Edit(object item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));

            switch (item)
            {
                case BankCustomer bankCustomer:
                    return EditBankCustomer(bankCustomer);
                default: throw new NotSupportedException($"Редактирование объекта типа {item.GetType().Name} невозможно!");
            }
        }

        public void ShowInformation(string information, string caption) => 
            MessageBox.Show(information, caption, MessageBoxButton.OK, MessageBoxImage.Information);

        public void ShowWarning(string message, string caption) => 
            MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Warning);

        public void ShowError(string message, string caption) => 
            MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Error);        

        public bool Confirm(string message, string caption, bool exclamation = false) =>
            MessageBox.Show(
                message,
                caption,
                MessageBoxButton.YesNo, 
                exclamation ? MessageBoxImage.Exclamation : MessageBoxImage.Question) 
            == MessageBoxResult.Yes;

        /// <summary>
        /// Редактирование клиента банка
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>        
        private static bool EditBankCustomer(BankCustomer bankCustomer)
        {
            var dlg = new AddBankCustomersWindow()
            {
                NameBankCustomer = bankCustomer.Passport.Holder.Name,
                SurnameBankCustomer = bankCustomer.Passport.Holder.Surname,
                PatronymicBankCustomer = bankCustomer.Passport.Holder.Patronymic,
                BirthdayBankCustomer = bankCustomer.Passport.Holder.Birthday,
                PlaceOfBirthBankCustomer = bankCustomer.Passport.Holder.PlaceOfBirth
            };

            if (dlg.ShowDialog() != true) return false;

            return true;
        }
    }
}
