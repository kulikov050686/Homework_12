using System.Windows.Controls;
using System.ComponentModel;
using System.Windows;
using System.Collections.Generic;
using System;
using System.Runtime.CompilerServices;

namespace UserControls
{
    public partial class DateUserControl : UserControl, INotifyPropertyChanged
    {
        #region Закрытые поля

        private static List<string> _months;
        private static List<int> _years;
        private static List<int> _numbers;
        private static int _startYear = 1900;
        private static int _startNumber = 1;
        private static int _maxNumber = 31;
        private static int _maxNumberInFebruary = 28;

        #endregion

        #region Название даты

        public static readonly DependencyProperty TitleUCProperty =
            DependencyProperty.Register(nameof(TitleUC),
                                        typeof(string),
                                        typeof(DateUserControl),
                                        new PropertyMetadata(default(string)));

        [Description("Название даты")]
        public string TitleUC
        {
            get => (string)GetValue(TitleUCProperty);
            set => SetValue(TitleUCProperty, value);
        }

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
            var value = (int)baseValue;

            switch (value)
            {
                case 0:
                    // январь
                    _maxNumber = 31;
                    //InitNumber();
                    break;
                case 1:
                    // февраль
                    _maxNumber = _maxNumberInFebruary;
                    //InitNumber();
                    break;
                case 2:
                    // март
                    _maxNumber = 31;
                    //InitNumber();
                    break;
                case 3:
                    // апрель
                    _maxNumber = 30;
                    //InitNumber();
                    break;
                case 4:
                    // май
                    _maxNumber = 31;
                    //InitNumber();
                    break;
                case 5:
                    // июнь
                    _maxNumber = 30;
                    //InitNumber();
                    break;
                case 6:
                    // июль
                    _maxNumber = 31;
                    //InitNumber();
                    break;
                case 7:
                    // август
                    _maxNumber = 31;
                    //InitNumber();
                    break;
                case 8:
                    // сентябрь
                    _maxNumber = 30;
                    //InitNumber();
                    break;
                case 9:
                    // октябрь
                    _maxNumber = 31;
                    //InitNumber();
                    break;
                case 10:
                    // ноябрь
                    _maxNumber = 30;
                    //InitNumber();
                    break;
                case 11:
                    // декабрь
                    _maxNumber = 31;
                    //InitNumber();
                    break;
            }

            return value;            
        }

        /// <summary>
        /// Проверяет новое установленное значение
        /// </summary>
        /// <param name="value"> Новое установленное значение </param>
        private static bool OnValidateMonth(object value)
        {
            //Если данный метод возвращает false, то привязка не сработает
            //Если данный метод возвращает true, то новое значение становится значением этого свойства

            var temp = (int)value;
            if (temp < 0 || temp > 11) return false;
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

            set
            {
                InitNumber();
                Set(ref _numbers, value); 
            }            
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
        private static void InitMonths()
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
        private static void InitYears()
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

        /// <summary>
        /// Событие для извещения об изменения свойства
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Метод для вызова события извещения об изменении свойства
        /// </summary>
        /// <param name="property"> Изменившееся свойство </param>
        public void OnPropertyChanged([CallerMemberName] string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        /// <summary>
        /// Метод для обновления значения свойства
        /// </summary>
        /// <typeparam name="T"> Тип данных свойства и поля </typeparam>
        /// <param name="field"> Поле </param>
        /// <param name="value"> Значение </param>
        /// <param name="property"> Изменившееся свойство </param>        
        public bool Set<T>(ref T field, T value, [CallerMemberName] string property = null)
        {
            if (Equals(field, value)) return false;

            field = value;
            OnPropertyChanged(property);

            return true;
        }
    }
}
