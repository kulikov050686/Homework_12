using System.Windows.Controls;
using System.ComponentModel;
using System.Windows;
using Models;

namespace UserControls
{    
    public partial class InfoBankCustomerUserControl : UserControl
    {
        #region Контекст данных

        public static new readonly DependencyProperty DataContextProperty =
            DependencyProperty.Register(nameof(DataContext),
                                        typeof(BankCustomer),
                                        typeof(PersonUserControl),
                                        new PropertyMetadata(default(BankCustomer)));

        [Description("Контекст данных")]
        public new BankCustomer DataContext
        {
            get => (BankCustomer)GetValue(DataContextProperty);
            set => SetValue(DataContextProperty, value);
        }

        #endregion

        public InfoBankCustomerUserControl() => InitializeComponent();        
    }
}
