using System.Windows.Controls;
using System.ComponentModel;
using System.Windows;

namespace UserControls
{    
    public partial class PassportUserControl : UserControl
    {
        #region Название

        public static readonly DependencyProperty TitleUCProperty =
           DependencyProperty.Register(nameof(TitleUC),
                                       typeof(string),
                                       typeof(PassportUserControl),
                                       new PropertyMetadata(default(string)));

        [Description("Название")]
        public string TitleUC
        {
            get => (string)GetValue(TitleUCProperty);
            set => SetValue(TitleUCProperty, value);
        }

        #endregion

        #region Место выдачи паспорта

        public static readonly DependencyProperty PlaceOfIssueUCProperty =
           DependencyProperty.Register(nameof(PlaceOfIssueUC),
                                       typeof(string),
                                       typeof(PassportUserControl),
                                       new PropertyMetadata(default(string)));

        [Description("Место выдачи паспорта")]
        public string PlaceOfIssueUC 
        {
            get => (string)GetValue(PlaceOfIssueUCProperty);
            set => SetValue(PlaceOfIssueUCProperty, value);
        }

        #endregion

        #region Номер

        public static readonly DependencyProperty NumberUCProperty =
           DependencyProperty.Register(nameof(NumberUC),
                                       typeof(ulong),
                                       typeof(PassportUserControl),
                                       new PropertyMetadata(default(ulong)));

        [Description("Номер паспорта")]
        public ulong NumberUC 
        {
            get => (ulong)GetValue(NumberUCProperty);
            set => SetValue(NumberUCProperty, value);
        }

        #endregion

        #region Серия паспорта

        public static readonly DependencyProperty SeriesUCProperty =
           DependencyProperty.Register(nameof(SeriesUC),
                                       typeof(ulong),
                                       typeof(PassportUserControl),
                                       new PropertyMetadata(default(ulong)));

        [Description("Серия паспорта")]
        public ulong SeriesUC 
        {
            get => (ulong)GetValue(SeriesUCProperty);
            set => SetValue(SeriesUCProperty, value);
        }

        #endregion

        #region Код подразделения 1

        public static readonly DependencyProperty DivisionCodeLeftUCProperty =
           DependencyProperty.Register(nameof(DivisionCodeLeftUC),
                                       typeof(ulong),
                                       typeof(PassportUserControl),
                                       new PropertyMetadata(default(ulong)));

        [Description("Код подразделения 1")]        
        public ulong DivisionCodeLeftUC
        {
            get => (ulong)GetValue(DivisionCodeLeftUCProperty);
            set => SetValue(DivisionCodeLeftUCProperty, value);
        }

        #endregion

        #region Код подразделения 2

        public static readonly DependencyProperty DivisionCodeRightUCProperty =
           DependencyProperty.Register(nameof(DivisionCodeRightUC),
                                       typeof(ulong),
                                       typeof(PassportUserControl),
                                       new PropertyMetadata(default(ulong)));

        [Description("Код подразделения 1")]
        public ulong DivisionCodeRightUC
        {
            get => (ulong)GetValue(DivisionCodeRightUCProperty);
            set => SetValue(DivisionCodeRightUCProperty, value);
        }

        #endregion

        #region
        #endregion

        public PassportUserControl() => InitializeComponent();        
    }
}
