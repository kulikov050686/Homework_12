using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Converters
{
    /// <summary>
    /// Конвертер базовых значений, который позволяет использовать XAML напрямую
    /// </summary>
    /// <typeparam name="T"> Тип преобразователя значения </typeparam>
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter where T: class, new()
    {
        /// <summary>
        /// Единственный статический экземпляр этого преобразователя значения
        /// </summary>
        private static T mConverter = null;

        /// <summary>
        /// Предоставляет статический экземпляр преобразователя значений
        /// </summary>
        /// <param name="serviceProvider"> Поставщик услуг </param>        
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return mConverter ?? (mConverter = new T());
        }

        /// <summary>
        /// Метод преобразования одного типа в другой
        /// </summary>        
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        /// <summary>
        /// Метод для преобразования значения обратно в его тип источника
        /// </summary>        
        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);       
    }
}
