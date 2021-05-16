using System.Windows.Controls;
using System.ComponentModel;
using System.Windows;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Services;
using System.Windows.Input;
using Commands;

namespace UserControls
{
    public partial class DateUserControl : UserControl, INotifyPropertyChanged
    {
        #region Закрытые поля

        static bool _leapYear = false;
        static int _monthNumber = 0;

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
        public List<string> Months { get; set; }

        #endregion

        #region Годы

        public List<int> Years { get; set; }

        #endregion

        #region Дни месяца

        List<int> _days;
        public List<int> Days
        {
            get => _days;
            set => Set(ref _days, value);
        }

        #endregion

        #region Выбор индекса месяца

        public static readonly DependencyProperty SelectedIndexMonthUCProperty =
            DependencyProperty.Register(nameof(SelectedIndexMonthUC),
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
            _monthNumber = (int)baseValue;
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

        [Description("Выбранный индекс месяца")]
        public int SelectedIndexMonthUC
        {
            get => (int)GetValue(SelectedIndexMonthUCProperty);
            set => SetValue(SelectedIndexMonthUCProperty, value);
        }

        #endregion
        
        #region Выбор индекса дня

        public static readonly DependencyProperty SelectedIndexDayUCProperty =
            DependencyProperty.Register(nameof(SelectedIndexDayUC),
                                        typeof(int),
                                        typeof(DateUserControl),
                                        new PropertyMetadata(default(int)));

        [Description("Выбранный индекс дня")]
        public int SelectedIndexDayUC
        {
            get => (int)GetValue(SelectedIndexDayUCProperty);
            set => SetValue(SelectedIndexDayUCProperty, value);
        }

        #endregion

        #region Выбор индекса года

        public static readonly DependencyProperty SelectedIndexYearUCroperty =
            DependencyProperty.Register(nameof(SelectedIndexYearUC),
                                        typeof(int),
                                        typeof(DateUserControl),
                                        new PropertyMetadata(default(int)));

        

        [Description("Выбранный индекс года")]
        public int SelectedIndexYearUC
        {
            get => (int)GetValue(SelectedIndexYearUCroperty);
            set => SetValue(SelectedIndexYearUCroperty, value);
        }

        #endregion

        #region Команда Выбора месяца 

        ICommand _OnSelectedMonth;
        public ICommand OnSelectedMonth
        {
            get => _OnSelectedMonth ?? (_OnSelectedMonth = new RelayCommand((obj) =>
            {
                SettingDays();
            }));
        }

        #endregion

        #region Команда выбранный год

        ICommand _OnSelectedYear;
        public ICommand OnSelectedYear
        {
            get => _OnSelectedYear ?? (_OnSelectedYear = new RelayCommand((obj) => 
            {
                int year = Years[SelectedIndexYearUC];
                _leapYear = year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
                SettingDays();
            }));
        }

        #endregion

        /// <summary>
        /// Конструктор
        /// </summary>
        public DateUserControl()
        { 
            InitializeComponent();
            Years = DaysMonthsYears.Years(1950, 2020);
            Months = DaysMonthsYears.Months();
            SettingDays();
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

        /// <summary>
        /// Установить количество дней в месяце
        /// </summary>
        private void SettingDays()
        {
            if (_monthNumber == 1)
            {
                if (_leapYear)
                {
                    Days = DaysMonthsYears.Days(29);
                    _leapYear = false;
                }
                else
                {
                    Days = DaysMonthsYears.Days(28);
                }

            }
            else if (_monthNumber == 0 ||
                    _monthNumber == 2 ||
                    _monthNumber == 4 ||
                    _monthNumber == 6 ||
                    _monthNumber == 7 ||
                    _monthNumber == 9 ||
                    _monthNumber == 11)
            {
                Days = DaysMonthsYears.Days(31);
            }
            else
            {
                Days = DaysMonthsYears.Days(30);
            }
        }
    }
}
