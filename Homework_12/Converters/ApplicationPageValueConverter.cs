using Enums;
using Pages;
using System;
using System.Globalization;

namespace Converters
{
    /// <summary>
    /// Преобразует <see cref="ApplicationPage"/> в фактический вид / страницу
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.MAINPAGE:
                    return new MainPage();
                default:                    
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
