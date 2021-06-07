using System;
using System.ComponentModel;
using System.Windows;

namespace Views
{
    public partial class AddBankCustomersWindow : Window
    {
        #region Имя

        public static readonly DependencyProperty NameBankCustomerProperty =
            DependencyProperty.Register(nameof(NameBankCustomer),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Имя")]
        public string NameBankCustomer
        {
            get => (string)GetValue(NameBankCustomerProperty);
            set => SetValue(NameBankCustomerProperty, value);
        }

        #endregion

        #region Фамилия

        public static readonly DependencyProperty SurnameBankCustomerProperty =
            DependencyProperty.Register(nameof(SurnameBankCustomer),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Фамилия")]
        public string SurnameBankCustomer
        {
            get => (string)GetValue(SurnameBankCustomerProperty);
            set => SetValue(SurnameBankCustomerProperty, value);
        }

        #endregion
        
        #region Отчество

        public static readonly DependencyProperty PatronymicBankCustomerProperty =
            DependencyProperty.Register(nameof(PatronymicBankCustomer),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Отчество")]
        public string PatronymicBankCustomer
        {
            get => (string)GetValue(PatronymicBankCustomerProperty);
            set => SetValue(PatronymicBankCustomerProperty, value);
        }

        #endregion

        #region Пол

        public static readonly DependencyProperty GenderBankCustomerProperty =
            DependencyProperty.Register(nameof(GenderBankCustomer),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Пол")]
        public string GenderBankCustomer
        {
            get => (string)GetValue(GenderBankCustomerProperty);
            set => SetValue(GenderBankCustomerProperty, value);
        }

        #endregion

        #region Дата рождения

        public static readonly DependencyProperty BirthdayBankCustomerProperty =
            DependencyProperty.Register(nameof(BirthdayBankCustomer),
                                        typeof(DateTime),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(DateTime)));

        [Description("Дата рождения")]
        public DateTime BirthdayBankCustomer
        {
            get => (DateTime)GetValue(BirthdayBankCustomerProperty);
            set => SetValue(BirthdayBankCustomerProperty, value);
        }

        #endregion

        #region Место рождения

        public static readonly DependencyProperty PlaceOfBirthBankCustomerProperty =
            DependencyProperty.Register(nameof(PlaceOfBirthBankCustomer),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Место рождения")]
        public string PlaceOfBirthBankCustomer 
        {
            get => (string)GetValue(PlaceOfBirthBankCustomerProperty);
            set => SetValue(PlaceOfBirthBankCustomerProperty, value); 
        }

        #endregion

        #region Номер паспорта

        public static readonly DependencyProperty NumberPassportProperty =
           DependencyProperty.Register(nameof(NumberPassport),
                                       typeof(long),
                                       typeof(AddBankCustomersWindow),
                                       new PropertyMetadata(default(long)));

        [Description("Номер паспорта клиента банка")]
        public long NumberPassport
        {
            get => (long)GetValue(NumberPassportProperty);
            set => SetValue(NumberPassportProperty, value);
        }

        #endregion

        #region Серия паспорта

        public static readonly DependencyProperty SeriesPassportProperty =
           DependencyProperty.Register(nameof(SeriesPassport),
                                       typeof(long),
                                       typeof(AddBankCustomersWindow),
                                       new PropertyMetadata(default(long)));

        [Description("Серия паспорта клиента банка")]
        public long SeriesPassport
        {
            get => (long)GetValue(SeriesPassportProperty);
            set => SetValue(SeriesPassportProperty, value);
        }

        #endregion

        #region Код подразделения левый

        public static readonly DependencyProperty DivisionCodeLeftPassportProperty =
           DependencyProperty.Register(nameof(DivisionCodeLeftPassport),
                                       typeof(int),
                                       typeof(AddBankCustomersWindow),
                                       new PropertyMetadata(default(int)));

        [Description("Код подразделения лывый")]
        public int DivisionCodeLeftPassport
        {
            get => (int)GetValue(DivisionCodeLeftPassportProperty);
            set => SetValue(DivisionCodeLeftPassportProperty, value);
        }

        #endregion

        #region Код подразделения правый

        public static readonly DependencyProperty DivisionCodeRightPassportProperty =
           DependencyProperty.Register(nameof(DivisionCodeRightPassport),
                                       typeof(int),
                                       typeof(AddBankCustomersWindow),
                                       new PropertyMetadata(default(int)));

        [Description("Код подразделения правый")]
        public int DivisionCodeRightPassport
        {
            get => (int)GetValue(DivisionCodeRightPassportProperty);
            set => SetValue(DivisionCodeRightPassportProperty, value);
        }

        #endregion

        #region Дата выдачи паспорта

        public static readonly DependencyProperty DateOfIssuePassportProperty =
           DependencyProperty.Register(nameof(DateOfIssuePassport),
                                       typeof(DateTime),
                                       typeof(AddBankCustomersWindow),
                                       new PropertyMetadata(default(DateTime)));

        [Description("Дата выдачи паспорта")]
        public DateTime DateOfIssuePassport
        {
            get => (DateTime)GetValue(DateOfIssuePassportProperty);
            set => SetValue(DateOfIssuePassportProperty, value);
        }

        #endregion

        #region Место выдачи паспорта

        public static readonly DependencyProperty PlaceOfIssuePassportProperty =
           DependencyProperty.Register(nameof(PlaceOfIssuePassport),
                                       typeof(string),
                                       typeof(AddBankCustomersWindow),
                                       new PropertyMetadata(default(string)));

        [Description("Место выдачи паспорта")]
        public string PlaceOfIssuePassport
        {
            get => (string)GetValue(PlaceOfIssuePassportProperty);
            set => SetValue(PlaceOfIssuePassportProperty, value);
        }

        #endregion

        #region Регион или Область адреса прописки

        public static readonly DependencyProperty RegionPlaceOfResidenceProperty =
            DependencyProperty.Register(nameof(RegionPlaceOfResidence),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Регион или область адреса прописки")]
        public string RegionPlaceOfResidence
        {
            get => (string)GetValue(RegionPlaceOfResidenceProperty);
            set => SetValue(RegionPlaceOfResidenceProperty, value);
        }

        #endregion

        #region Город адреса прописки

        public static readonly DependencyProperty CityPlaceOfResidenceProperty =
            DependencyProperty.Register(nameof(CityPlaceOfResidence),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Город адреса прописки")]
        public string CityPlaceOfResidence
        {
            get => (string)GetValue(CityPlaceOfResidenceProperty);
            set => SetValue(CityPlaceOfResidenceProperty, value);
        }

        #endregion

        #region Район города адреса прописки

        public static readonly DependencyProperty DistrictPlaceOfResidenceProperty =
            DependencyProperty.Register(nameof(DistrictPlaceOfResidence),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Район города адреса прописки")]
        public string DistrictPlaceOfResidence
        {
            get => (string)GetValue(DistrictPlaceOfResidenceProperty);
            set => SetValue(DistrictPlaceOfResidenceProperty, value);
        }

        #endregion

        #region Название улицы адреса прописки

        public static readonly DependencyProperty StreetPlaceOfResidenceProperty =
            DependencyProperty.Register(nameof(StreetPlaceOfResidence),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Название улицы адреса прописки")]
        public string StreetPlaceOfResidence
        {
            get => (string)GetValue(StreetPlaceOfResidenceProperty);
            set => SetValue(StreetPlaceOfResidenceProperty, value);
        }

        #endregion

        #region Номер дома адреса прописки

        public static readonly DependencyProperty HouseNumberPlaceOfResidenceProperty =
            DependencyProperty.Register(nameof(HouseNumberPlaceOfResidence),
                                        typeof(int),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(int)));

        [Description("Номер дома адреса прописки")]
        public int HouseNumberPlaceOfResidence
        {
            get => (int)GetValue(HouseNumberPlaceOfResidenceProperty);
            set => SetValue(HouseNumberPlaceOfResidenceProperty, value);
        }

        #endregion

        #region Корпус дома адреса прописки

        public static readonly DependencyProperty HousingPlaceOfResidenceProperty =
            DependencyProperty.Register(nameof(HousingPlaceOfResidence),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Корпус дома адреса прописки")]
        public string HousingPlaceOfResidence
        {
            get => (string)GetValue(HousingPlaceOfResidenceProperty);
            set => SetValue(HousingPlaceOfResidenceProperty, value);
        }

        #endregion

        #region Номер квартиры адреса прописки

        public static readonly DependencyProperty ApartmentNumberPlaceOfResidenceProperty =
            DependencyProperty.Register(nameof(ApartmentNumberPlaceOfResidence),
                                        typeof(int),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(int)));

        [Description("Номер квартиры адреса прописки")]
        public int ApartmentNumberPlaceOfResidence
        {
            get => (int)GetValue(ApartmentNumberPlaceOfResidenceProperty);
            set => SetValue(ApartmentNumberPlaceOfResidenceProperty, value);
        }

        #endregion

        #region Дата регистрации адреса прописки

        public static readonly DependencyProperty RegistrationDatePlaceOfResidenceProperty =
            DependencyProperty.Register(nameof(RegistrationDatePlaceOfResidence),
                                        typeof(DateTime),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(DateTime)));

        [Description("Дата регистрации адреса прописки")]
        public DateTime RegistrationDatePlaceOfResidence
        {
            get => (DateTime)GetValue(RegistrationDatePlaceOfResidenceProperty);
            set => SetValue(RegistrationDatePlaceOfResidenceProperty, value);
        }

        #endregion

        #region Регион или Область адреса регистрации

        public static readonly DependencyProperty RegionRegistrationProperty =
            DependencyProperty.Register(nameof(RegionRegistration),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Регион или область адреса регистрации")]
        public string RegionRegistration
        {
            get => (string)GetValue(RegionRegistrationProperty);
            set => SetValue(RegionRegistrationProperty, value);
        }

        #endregion

        #region Город адреса регистрации

        public static readonly DependencyProperty CityRegistrationProperty =
            DependencyProperty.Register(nameof(CityRegistration),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Город адреса регистрации")]
        public string CityRegistration
        {
            get => (string)GetValue(CityRegistrationProperty);
            set => SetValue(CityRegistrationProperty, value);
        }

        #endregion

        #region Район города адреса регистрации

        public static readonly DependencyProperty DistrictRegistrationProperty =
            DependencyProperty.Register(nameof(DistrictRegistration),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Район города адреса регистрации")]
        public string DistrictRegistration
        {
            get => (string)GetValue(DistrictRegistrationProperty);
            set => SetValue(DistrictRegistrationProperty, value);
        }

        #endregion

        #region Название улицы адреса регистрации

        public static readonly DependencyProperty StreetRegistrationProperty =
            DependencyProperty.Register(nameof(StreetRegistration),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Название улицы адреса регистрация")]
        public string StreetRegistration
        {
            get => (string)GetValue(StreetRegistrationProperty);
            set => SetValue(StreetRegistrationProperty, value);
        }

        #endregion

        #region Номер дома адреса регистрации

        public static readonly DependencyProperty HouseNumberRegistrationProperty =
            DependencyProperty.Register(nameof(HouseNumberRegistration),
                                        typeof(int),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(int)));

        [Description("Номер дома адреса регистрации")]
        public int HouseNumberRegistration
        {
            get => (int)GetValue(HouseNumberRegistrationProperty);
            set => SetValue(HouseNumberRegistrationProperty, value);
        }

        #endregion

        #region Корпус дома адреса регистрации

        public static readonly DependencyProperty HousingRegistrationProperty =
            DependencyProperty.Register(nameof(HousingRegistration),
                                        typeof(string),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(string)));

        [Description("Корпус дома адреса регистрации")]
        public string HousingRegistration
        {
            get => (string)GetValue(HousingRegistrationProperty);
            set => SetValue(HousingRegistrationProperty, value);
        }

        #endregion

        #region Номер квартиры адреса регистрации

        public static readonly DependencyProperty ApartmentNumberRegistrationProperty =
            DependencyProperty.Register(nameof(ApartmentNumberRegistration),
                                        typeof(int),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(int)));

        [Description("Номер квартиры адреса регистрации")]
        public int ApartmentNumberRegistration
        {
            get => (int)GetValue(ApartmentNumberRegistrationProperty);
            set => SetValue(ApartmentNumberRegistrationProperty, value);
        }

        #endregion

        #region Дата регистрации адреса регистрации

        public static readonly DependencyProperty RegistrationDateRegistrationProperty =
            DependencyProperty.Register(nameof(RegistrationDateRegistration),
                                        typeof(DateTime),
                                        typeof(AddBankCustomersWindow),
                                        new PropertyMetadata(default(DateTime)));

        [Description("Дата регистрации адреса регистрации")]
        public DateTime RegistrationDateRegistration
        {
            get => (DateTime)GetValue(RegistrationDateRegistrationProperty);
            set => SetValue(RegistrationDateRegistrationProperty, value);
        }

        #endregion

        public AddBankCustomersWindow() => InitializeComponent();        
    }
}
