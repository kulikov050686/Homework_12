using System.Windows;
using System.ComponentModel;
using System.Collections;

namespace Views
{
    public partial class SelectedBankAccountWindow : Window
    {
        #region Список счетов

        public static readonly DependencyProperty BankAccountsProperty =
            DependencyProperty.Register(nameof(BankAccounts),
                                        typeof(IEnumerable),
                                        typeof(SelectedBankAccountWindow),
                                        new PropertyMetadata(default(IEnumerable)));

        /// <summary>
        /// Список счетов
        /// </summary>
        [Description("Список счетов")]
        public IEnumerable BankAccounts
        {
            get => (IEnumerable)GetValue(BankAccountsProperty);
            set => SetValue(BankAccountsProperty, value);
        }

        #endregion

        #region Выбранный счёт

        public static readonly DependencyProperty SelectedBankAccountProperty =
            DependencyProperty.Register(nameof(SelectedBankAccount),
                                        typeof(object),
                                        typeof(SelectedBankAccountWindow),
                                        new PropertyMetadata(default(object)));

        /// <summary>
        /// Выбранный счёт
        /// </summary>
        [Description("Выбранный счёт")]
        public object SelectedBankAccount
        {
            get => GetValue(SelectedBankAccountProperty);
            set => SetValue(SelectedBankAccountProperty, value);
        }

        #endregion

        public SelectedBankAccountWindow() => InitializeComponent();        
    }
}
