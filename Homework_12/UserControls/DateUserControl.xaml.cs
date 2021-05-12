using System.Windows.Controls;
using System.ComponentModel;
using System.Windows;
using System.Collections.Generic;
using System;

namespace UserControls
{
    public partial class DateUserControl : UserControl
    {
        #region Закрытые поля

        private List<string> _months;
        private List<int> _years;
        private List<int> _numbers;
        private int _startYear = 1900;
        private int _startNumber = 1;
        private int _maxNumber = 31;
        private int _maxNumberInFebruary = 28;

        #endregion

        #region Месяцы

        [Description("Месяцы")]
        public List<string> Months
        {
            get => _months;
        }

        #endregion

        #region Выбор месяца

        public static readonly DependencyProperty MonthUCProperty =
            DependencyProperty.Register(nameof(MonthUC),
                                        typeof(int),
                                        typeof(DateUserControl),
                                        new PropertyMetadata(default(int), 
                                            OnMonthPropertyChanged,
                                            OnCorrectionMonth), 
                                        OnValidateMonth);

        /// <summary>
        /// Вызывается всякий раз когда свойство MonthUC меняется
        /// </summary>
        /// <param name="d"> Объект для которого изменется свойство </param>
        /// <param name="e"> Объект который содержит информацию о том как это свойство меняется </param>
        private static void OnMonthPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        /// <summary>
        /// Метод корректирует значение свойства MonthUC
        /// </summary>
        /// <param name="d"> Объект для которого изменется свойство </param>
        /// <param name="baseValue"> Установленное значение </param>        
        private static object OnCorrectionMonth(DependencyObject d, object baseValue)
        {
            return baseValue;
        }

        /// <summary>
        /// Проверяет новое установленное значение
        /// </summary>
        /// <param name="value"> Новое установленное значение </param>        
        private static bool OnValidateMonth(object value)
        {
            //Если данный метод возвращает false, то привязка не сработает
            //Если данный метод возвращает true, то новое значение становится значением этого свойства
            return true;
        }

        [Description("Выбранный месяц")]
        public int MonthUC
        {
            get => (int)GetValue(MonthUCProperty);
            set => SetValue(MonthUCProperty, value);
        }

        #endregion

        #region Числа месяца

        public List<int> Numbers
        {
            get => _numbers;
        }

        #endregion

        #region Выбор числа

        public static readonly DependencyProperty NumberUCProperty =
            DependencyProperty.Register(nameof(NumberUC),
                                        typeof(int),
                                        typeof(DateUserControl),
                                        new PropertyMetadata(default(int)));

        [Description("Выбранное число месяца")]
        public int NumberUC
        {
            get => (int)GetValue(NumberUCProperty);
            set => SetValue(NumberUCProperty, value);
        }

        #endregion

        #region Годы

        public List<int> Years
        {
            get => _years;
        }

        #endregion

        #region Выбор года

        public static readonly DependencyProperty YearUCProperty =
            DependencyProperty.Register(nameof(YearUC),
                                        typeof(int),
                                        typeof(DateUserControl),
                                        new PropertyMetadata(default(int)));

        [Description("Выбранный год")]
        public int YearUC
        {
            get => (int)GetValue(YearUCProperty);
            set => SetValue(YearUCProperty, value);
        }

        #endregion

        public DateUserControl() 
        { 
            InitializeComponent();
            InitMonths();
            InitYears();            
        }

        /// <summary>
        /// Инициализация месяцев
        /// </summary>
        private void InitMonths()
        {
            _months = new List<string> { "январь",
                                        "февраль",
                                        "март",
                                        "апрель",
                                        "май",
                                        "июнь",
                                        "июль",
                                        "август",
                                        "сентябрь",
                                        "октябрь",
                                        "ноябрь",
                                        "декабрь" };
        }

        /// <summary>
        /// Инициализация годов
        /// </summary>
        private void InitYears()
        {
            _years = new List<int>();

            for(int i = 0; i < 130; i++)
            {
                _years.Add(_startYear + i);                
            }
        }

        /// <summary>
        /// Инициализация чисел
        /// </summary>
        private void InitNumber()
        {
            _numbers = new List<int>();

            for (int i = 0; i < _maxNumber; i++)
            {
                _numbers.Add(_startNumber + i);
            }
        }

        
    }
}
