using Enums;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace Views
{   
    public partial class AddDepositoryAccountWindow : Window
    {
        #region Сумма

        public static readonly DependencyProperty AmountProperty =
            DependencyProperty.Register(nameof(Amount),
                                        typeof(double),
                                        typeof(AddDepositoryAccountWindow),
                                        new PropertyMetadata(default(double)));

        /// <summary>
        /// Сумма
        /// </summary>
        [Description("Сумма")]
        public double Amount
        {
            get => (double)GetValue(AmountProperty);
            set => SetValue(AmountProperty, value);
        }

        #endregion

        #region Процентная ставка

        public static readonly DependencyProperty InterestRateProperty =
            DependencyProperty.Register(nameof(InterestRate),
                                        typeof(double),
                                        typeof(AddDepositoryAccountWindow),
                                        new PropertyMetadata(default(double)));

        /// <summary>
        /// Процентная ставка
        /// </summary>
        [Description("Процентная ставка")]
        public double InterestRate
        {
            get => (double)GetValue(InterestRateProperty);
            set => SetValue(InterestRateProperty, value);
        }

        #endregion

        #region Лист Статусов депозита

        [Description("Лист Статусов депозита")]
        public List<string> DepositStatusList { get; set; } = new List<string> {"Без капитализации", "С капитализацией" };

        #endregion

        #region Выбор статуса депозита

        public static readonly DependencyProperty SelectedDepositStatusProperty =
            DependencyProperty.Register(nameof(SelectedDepositStatus),
                                        typeof(DepositStatus),
                                        typeof(AddDepositoryAccountWindow),
                                        new PropertyMetadata(default(DepositStatus)));

        /// <summary>
        /// Выбор статуса депозита
        /// </summary>
        [Description("Выбор статуса депозита")]
        public DepositStatus SelectedDepositStatus
        {
            get => (DepositStatus)GetValue(SelectedDepositStatusProperty);
            set => SetValue(SelectedDepositStatusProperty, value);
        }

        #endregion

        public AddDepositoryAccountWindow() => InitializeComponent();        
    }
}
