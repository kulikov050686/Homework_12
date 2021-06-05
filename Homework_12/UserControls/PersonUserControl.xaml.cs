using System.Windows.Controls;
using System.ComponentModel;
using System.Windows;
using System.Collections.Generic;
using System;

namespace UserControls
{
    public partial class PersonUserControl : UserControl
    {
        #region Название

        public static readonly DependencyProperty TitleUCProperty =
            DependencyProperty.Register(nameof(TitleUC),
                                        typeof(string),
                                        typeof(PersonUserControl),
                                        new PropertyMetadata(default(string)));

        [Description("Название")]
        public string TitleUC
        {
            get => (string)GetValue(TitleUCProperty);
            set => SetValue(TitleUCProperty, value);
        }

        #endregion

        #region Имя

        public static readonly DependencyProperty NameUCProperty =
            DependencyProperty.Register(nameof(NameUC),
                                        typeof(string),
                                        typeof(PersonUserControl),
                                        new PropertyMetadata(default(string)));

        [Description("Имя")]
        public string NameUC
        {
            get => (string)GetValue(NameUCProperty);
            set => SetValue(NameUCProperty, value);
        }

        #endregion

        #region Фамилия

        public static readonly DependencyProperty SurnameUCProperty =
            DependencyProperty.Register(nameof(SurnameUC),
                                        typeof(string),
                                        typeof(PersonUserControl),
                                        new PropertyMetadata(default(string)));

        [Description("Фамилия")]
        public string SurnameUC 
        {
            get => (string)GetValue(SurnameUCProperty);
            set => SetValue(SurnameUCProperty, value);
        }

        #endregion

        #region Отчество

        public static readonly DependencyProperty PatronymicUCProperty =
            DependencyProperty.Register(nameof(PatronymicUC),
                                        typeof(string),
                                        typeof(PersonUserControl),
                                        new PropertyMetadata(default(string)));

        [Description("Отчество")]
        public string PatronymicUC
        {
            get => (string)GetValue(PatronymicUCProperty);
            set => SetValue(PatronymicUCProperty, value);
        }

        #endregion

        #region Место рождения

        public static readonly DependencyProperty PlaceOfBirthUCProperty =
            DependencyProperty.Register(nameof(PlaceOfBirthUC),
                                        typeof(string),
                                        typeof(PersonUserControl),
                                        new PropertyMetadata(default(string)));

        [Description("Место рождения")]
        public string PlaceOfBirthUC
        {
            get => (string)GetValue(PlaceOfBirthUCProperty);
            set => SetValue(PlaceOfBirthUCProperty, value);
        }

        #endregion

        #region Пол

        [Description("Пол")]
        public List<string> GenderUC { get; set; }

        #endregion

        #region Выбор индекса пола

        public static readonly DependencyProperty SelectedIndexGenderUCProperty =
            DependencyProperty.Register(nameof(SelectedIndexGenderUC),
                                        typeof(int),
                                        typeof(PersonUserControl),
                                        new PropertyMetadata(default(int)));

        [Description("Выбранный индекс пола")]
        public int SelectedIndexGenderUC
        {
            get => (int)GetValue(SelectedIndexGenderUCProperty);
            set => SetValue(SelectedIndexGenderUCProperty, value);
        }

        #endregion

        #region Выбор пола

        public static readonly DependencyProperty SelectedItemGenderUCProperty =
            DependencyProperty.Register(nameof(SelectedItemGenderUC),
                                        typeof(string),
                                        typeof(PersonUserControl),
                                        new PropertyMetadata(default(string)));

        [Description("Выбранный пол")]
        public string SelectedItemGenderUC
        {
            get => (string)GetValue(SelectedItemGenderUCProperty);
            set => SetValue(SelectedItemGenderUCProperty, value);
        }

        #endregion

        #region Дата рождения

        public static readonly DependencyProperty DateOfBirthrUCProperty =
            DependencyProperty.Register(nameof(DateOfBirthrUC),
                                        typeof(DateTime),
                                        typeof(PersonUserControl),
                                        new PropertyMetadata(default(DateTime)));

        [Description("Дата рождения")]
        public DateTime DateOfBirthrUC
        {
            get => (DateTime)GetValue(DateOfBirthrUCProperty);
            set => SetValue(DateOfBirthrUCProperty, value);
        }

        #endregion

        public PersonUserControl()
        {
            InitializeComponent();
            GenderUC = new List<string> { "муж", "жен" };
        }
    }
}
