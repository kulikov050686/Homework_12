using Enums;
using System;
using System.Globalization;

namespace Converters
{
    public class DepositStatusConverter : BaseValueConverter<DepositStatusConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((DepositStatus)value)
            {
                case DepositStatus.WITHOUTCAPITALIZATION:
                    return 0;
                case DepositStatus.WITHCAPITALIZATION:
                    return 1;                
                default:
                    return 0;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((int)value)
            {
                case 0:
                    return DepositStatus.WITHOUTCAPITALIZATION;
                case 1:
                    return DepositStatus.WITHCAPITALIZATION;
                default:
                    return 0;
            }
        }
    }
}
