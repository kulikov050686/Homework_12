using System;
using System.ComponentModel;
using System.Windows;

namespace Views
{
    public partial class PassportWindow : Window
    {
        #region Номер паспорта

        public static readonly DependencyProperty NumberProperty =
           DependencyProperty.Register(nameof(Number),
                                       typeof(long),
                                       typeof(PassportWindow),
                                       new PropertyMetadata(default(long)));

        [Description("Номер паспорта")]
        public long Number
        {
            get => (long)GetValue(NumberProperty);
            set => SetValue(NumberProperty, value);
        }

        #endregion

        #region Серия паспорта

        public static readonly DependencyProperty SeriesProperty =
           DependencyProperty.Register(nameof(Series),
                                       typeof(long),
                                       typeof(PassportWindow),
                                       new PropertyMetadata(default(long)));

        [Description("Серия паспорта")]
        public long Series
        {
            get => (long)GetValue(SeriesProperty);
            set => SetValue(SeriesProperty, value);
        }

        #endregion

        #region Код подразделения левый

        public static readonly DependencyProperty DivisionCodeLeftProperty =
           DependencyProperty.Register(nameof(DivisionCodeLeft),
                                       typeof(int),
                                       typeof(PassportWindow),
                                       new PropertyMetadata(default(int)));

        [Description("Код подразделения левый")]
        public int DivisionCodeLeft
        {
            get => (int)GetValue(DivisionCodeLeftProperty);
            set => SetValue(DivisionCodeLeftProperty, value);
        }

        #endregion

        #region Код подразделения правый

        public static readonly DependencyProperty DivisionCodeRightProperty =
           DependencyProperty.Register(nameof(DivisionCodeRight),
                                       typeof(int),
                                       typeof(PassportWindow),
                                       new PropertyMetadata(default(int)));

        [Description("Код подразделения правый")]
        public int DivisionCodeRight
        {
            get => (int)GetValue(DivisionCodeRightProperty);
            set => SetValue(DivisionCodeRightProperty, value);
        }

        #endregion

        #region Дата выдачи паспорта

        public static readonly DependencyProperty DateOfIssueProperty =
           DependencyProperty.Register(nameof(DateOfIssue),
                                       typeof(DateTime),
                                       typeof(PassportWindow),
                                       new PropertyMetadata(default(DateTime)));

        [Description("Дата выдачи паспорта")]
        public DateTime DateOfIssue
        {
            get => (DateTime)GetValue(DateOfIssueProperty);
            set => SetValue(DateOfIssueProperty, value);
        }

        #endregion

        #region Место выдачи паспорта

        public static readonly DependencyProperty PlaceOfIssueProperty =
           DependencyProperty.Register(nameof(PlaceOfIssue),
                                       typeof(string),
                                       typeof(PassportWindow),
                                       new PropertyMetadata(default(string)));

        [Description("Место выдачи паспорта")]
        public string PlaceOfIssue
        {
            get => (string)GetValue(PlaceOfIssueProperty);
            set => SetValue(PlaceOfIssueProperty, value);
        }

        #endregion

        public PassportWindow() => InitializeComponent();        
    }
}
