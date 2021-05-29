using System;
using System.ComponentModel;
using System.Windows;

namespace Views
{    
    public partial class AddBankCustomersWindow : Window
    {
        #region Имя клиента банка

        public static readonly DependencyProperty NameBankCustomerProperty =
            DependencyProperty.Register(nameof(NameBankCustomer),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Имя клиента")]
        public string NameBankCustomer
        {
            get => (string)GetValue(NameBankCustomerProperty);
            set => SetValue(NameBankCustomerProperty, value);
        }

        #endregion

        #region Фамилия клиента банка

        public static readonly DependencyProperty SurnameBankCustomerProperty =
            DependencyProperty.Register(nameof(SurnameBankCustomer),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Фамилия клиента банка")]        
        public string SurnameBankCustomer 
        {
            get => (string)GetValue(SurnameBankCustomerProperty);
            set => SetValue(SurnameBankCustomerProperty, value);
        }

        #endregion

        #region Отчество клиента банка

        public static readonly DependencyProperty PatronymicBankCustomerProperty =
            DependencyProperty.Register(nameof(PatronymicBankCustomer),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Отчество клиента банка")]
        public string PatronymicBankCustomer
        {
            get => (string)GetValue(PatronymicBankCustomerProperty);
            set => SetValue(PatronymicBankCustomerProperty, value);
        }

        #endregion

        #region Пол клиента банка

        public static readonly DependencyProperty GenderBankCustomerProperty =
            DependencyProperty.Register(nameof(GenderBankCustomer),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Пол клиента банка")]
        public string GenderBankCustomer 
        {
            get => (string)GetValue(GenderBankCustomerProperty);
            set => SetValue(GenderBankCustomerProperty, value); 
        }

        #endregion

        #region Дата рождения клиента банка

        public static readonly DependencyProperty BirthdayBankCustomerProperty =
            DependencyProperty.Register(nameof(BirthdayBankCustomer),
                                        typeof(DateTime),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(DateTime)));

        [Description("Дата рождения клиента банка")]
        public DateTime BirthdayBankCustomer 
        {
            get => (DateTime)GetValue(BirthdayBankCustomerProperty);
            set => SetValue(BirthdayBankCustomerProperty, value);
        }

        #endregion

        #region Место рождения клиента банка

        public static readonly DependencyProperty PlaceOfBirthBankCustomerProperty =
            DependencyProperty.Register(nameof(PlaceOfBirthBankCustomer),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Место рождения клиента банка")]
        public string PlaceOfBirthBankCustomer 
        {
            get => (string)GetValue(PlaceOfBirthBankCustomerProperty);
            set => SetValue(PlaceOfBirthBankCustomerProperty, value); 
        }

        #endregion

        public AddBankCustomersWindow() => InitializeComponent();        
    }
}
