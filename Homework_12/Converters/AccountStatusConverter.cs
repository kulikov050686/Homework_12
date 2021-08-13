using Enums;
using System;
using System.Globalization;

namespace Converters
{
    /// <summary>
    /// Конвертор для перобразования статуса счёта
    /// </summary>
    public class AccountStatusConverter : BaseValueConverter<AccountStatusConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((AccountStatus)value)
            {
                case AccountStatus.DEPOSITORY:
                    return "Депозитный счёт";
                case AccountStatus.CREDIT:
                    return "Кредитный счёт";
                default:
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((string)value)
            {                
                case "Депозитный счёт":
                    return AccountStatus.DEPOSITORY;
                case "Кредитный счёт":
                    return AccountStatus.CREDIT;
                default:
                    return null;
            }
        }
    }
}
